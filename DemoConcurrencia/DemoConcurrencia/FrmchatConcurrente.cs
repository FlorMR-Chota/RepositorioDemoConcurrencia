using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmchatConcurrente : Form
    {
        private int contadorUsuarios = 0;
        private object bloqueo = new(); // Para controlar el acceso concurrente
        private SemaphoreSlim semaforo = new SemaphoreSlim(5); // Límite de 5 usuarios concurrentes
        private bool chatActivo = false;
        public FrmchatConcurrente()
        {
            InitializeComponent();
        }

        private void btnIniciarchat_Click(object sender, EventArgs e)
        {
            chatActivo = true;
            Task.Run(() =>
            {
                while (chatActivo)
                {
                    semaforo.Wait(); // Reservar un "espacio" para el usuario
                    Task.Run(() => SimularUsuario());
                }
            });
        }

        private void btnDetenerChat_Click(object sender, EventArgs e)
        {
            chatActivo = false;
            semaforo.Release(5); // Liberar el semáforo para detener tareas en ejecución
            ActualizarMensajes("Chat detenido.");
        }

        private void btnPausarUsuario_Click(object sender, EventArgs e)
        {
            lock (bloqueo)
            {
                ActualizarMensajes("Pausa solicitada, esperando condiciones...");
                Monitor.Wait(bloqueo); // Espera activa
            }
        }

        private void btnReanudarUsuario_Click(object sender, EventArgs e)
        {
            lock (bloqueo)
            {
                Monitor.PulseAll(bloqueo); // Reanuda todos los usuarios pausados
                ActualizarMensajes("Usuarios reanudados.");
            }
        }

        private void SimularUsuario()
        {
            try
            {
                lock (bloqueo)
                {
                    contadorUsuarios++;
                    ActualizarMensajes($"Usuario {contadorUsuarios}: Ingresó al chat.");

                    for (int i = 0; i < 5; i++) // Simula varios mensajes por usuario
                    {
                        if (!chatActivo) break;
                        ActualizarMensajes($"Usuario {contadorUsuarios}: Mensaje {i + 1}");
                        Thread.Sleep(1000); // Simular envío de mensajes
                    }

                    ActualizarMensajes($"Usuario {contadorUsuarios}: Salió del chat.");
                    contadorUsuarios--;
                }
            }
            finally
            {
                semaforo.Release(); // Liberar el semáforo para otros usuarios
            }
        }

        private void ActualizarMensajes(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarMensajes(mensaje)));
                return;
            }
            TxtMensajes.AppendText($"{DateTime.Now:HH:mm:ss}: {mensaje}{Environment.NewLine}");
        }
    }
}
           

