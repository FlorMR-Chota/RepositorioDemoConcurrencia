namespace DemoConcurrencia
{
    public partial class FrmConcurrencia : Form
    {
        private CancellationTokenSource _cts;
        public FrmConcurrencia()
        {
            InitializeComponent();
        }

        private void BtnSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando proceso secuencial... ");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                ActualizarResultado($" Actividad - paso {i + 1}");
            }
            ActualizarResultado("Fin proceso secuencial.");
        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now: HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }

        private void BtnIniciarHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread hilo1 = new Thread(() =>
            {
                try
                {
                    ActualizarResultado($" Iniciar nuevo thread{Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ActualizarResultado($" Actividad en hilo {Thread.CurrentThread.ManagedThreadId}: - Paso {i + 1}");
                    }
                    ActualizarResultado($" thread {Thread.CurrentThread.ManagedThreadId}Terminado.");

                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Hilo Cancelado. ");
                }
            });
            hilo1.Start();
        }

        private async void BtnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciando Task{Task.CurrentId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ActualizarResultado($"Actividad de Tarea  {Task.CurrentId} - Paso {i + 1}");
                    }
                    ActualizarResultado($"Task {Task.CurrentId} completada");

                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Tarea cancelada.");
                }

            });
        }

        private void BtnCancelarHilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}
