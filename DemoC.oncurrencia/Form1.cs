using System.Threading;

namespace DemoC.oncurrencia
{
    public partial class FrmConcurrencia : Form
    {
        private CancellationTokenSource _cts;

        public FrmConcurrencia()
        {
            InitializeComponent();
        }

        private void btnIniciarHilos_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread hilo1 = new Thread(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciar un nuevo thread{Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(1000);
                        ActualizarResultado($"Actividad  en Hilo {Thread.CurrentThread.ManagedThreadId}  - Paso {i + 1}");
                    }

                    ActualizarResultado($"Threard {Thread.CurrentThread.ManagedThreadId} terminado.");
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Hilo cancelado");
                }
              
            });
            hilo1.Start();
        }



        private void btnIniciarSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("INICIANDO PROCESO SECUENCIAL...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                ActualizarResultado($"Actividad - Paso {i + 1}");
            }
            ActualizarResultado("FIN DE PROCESO SECUENCIAL...");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss:fff}:{mensaje}{Environment.NewLine}");
        }

        private async void btnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
            {

                try
                {
                    ActualizarResultado($"Iniciando Tarea {Task.CurrentId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(1000);
                        ActualizarResultado($"Actividad en tarea {Task.CurrentId} - Paso {i + 1}");
                    }

                    ActualizarResultado($"Task {Task.CurrentId} Completada");
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Tarea Cancelada");
                }
               
            });

        }

        private void btnCancelarHilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}