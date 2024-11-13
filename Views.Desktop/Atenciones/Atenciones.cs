using Logic;
using Models.Entity.Clases;
using Models.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Views.Desktop.Atenciones
{
    public partial class Atenciones : Form
    {
        private Form _padre;

        public Atenciones(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
            _padre = padre;
            SetupDataGridViewColumns();
            dgvAtenciones.CellClick += dataGridViewAttentions_CellClick;
        }

       

        private async void SetupDataGridViewColumns()
        {

            try
            {
                var atenciones = await AtencionLogic.GetAllInfoAtencionesRealizadas();
                if (atenciones != null)
                {
                    dgvAtenciones.AutoGenerateColumns = true;

                    dgvAtenciones.DataSource = atenciones.ToList();

                    //Oculto las columnas que no me interesan
                    string[] columnasOcultas = { "AtencionId", "MascotaId", "UsuarioId", "Activo" };

                    foreach (DataGridViewColumn column in dgvAtenciones.Columns)
                    {
                        if (columnasOcultas.Contains(column.Name))
                        {
                            column.Visible = false;
                        }
                    }

                }

                else
                {
                    MessageBox.Show("No se encontraron atenciones.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las atenciones: {ex.Message}");
            }



            if (!dgvAtenciones.Columns.Contains("detallesButton"))
            {
                DataGridViewButtonColumn detallesButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Detalles",
                    Name = "detallesButton",
                    Text = "Ver detalles",
                    UseColumnTextForButtonValue = true
                };
                dgvAtenciones.Columns.Add(detallesButton);
            }

            if (!dgvAtenciones.Columns.Contains("PagoButton"))
            {
                DataGridViewButtonColumn pagoButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Pago",
                    Name = "PagoButton",
                    Text = "Registrar pago",
                    UseColumnTextForButtonValue = true
                };
                dgvAtenciones.Columns.Add(pagoButton);
            }
        }

        private async void dataGridViewAttentions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvAtenciones.Columns["detallesButton"].Index)
            {
                string observacionesFila = dgvAtenciones.Rows[e.RowIndex].Cells["Observaciones"].Value?.ToString();
                string motivoAtencionFila = dgvAtenciones.Rows[e.RowIndex].Cells["Motivo"].Value?.ToString();
                int dniFila = Convert.ToInt32(dgvAtenciones.Rows[e.RowIndex].Cells["DniCliente"].Value);
                int idAtencion = Convert.ToInt32(dgvAtenciones.Rows[e.RowIndex].Cells["AtencionId"].Value);
                List<Servicio> serviciosRealizados = await ServiciosLogic.GetServiciosByIdAtencion(idAtencion);

                string serviciosRealizadosAsString = (serviciosRealizados != null && serviciosRealizados.Any(s => s.Nombre != null))
                ? string.Join(", ", serviciosRealizados.Where(s => s.Nombre != null).Select(s => s.Nombre))
                : "No se realizaron servicios";


                MembresiaInfo infoMembresiaDelCliente = await ClientesMembresiasLogic.GetInfoUltimaMembresiaByDni(dniFila);
                if (infoMembresiaDelCliente != null)
                {

                    decimal descuentoAplicado = infoMembresiaDelCliente.PorcentajeDescuento ?? 0m; //Si PorcentajeDescuento es nulo, le asigna 0.
                    string descripcionMembresia = infoMembresiaDelCliente.Descripcion;

                    ObservacionesForm detallesForm = new ObservacionesForm(observacionesFila, motivoAtencionFila, descuentoAplicado, descripcionMembresia, serviciosRealizadosAsString);
                    detallesForm.ShowDialog();
                }
                else
                {
                    ObservacionesForm detallesForm = new ObservacionesForm(observacionesFila, motivoAtencionFila, 0, "", serviciosRealizadosAsString);
                    detallesForm.ShowDialog();
                }

            }
            else if (e.ColumnIndex == dgvAtenciones.Columns["PagoButton"].Index)
            {
                DataGridViewRow row = dgvAtenciones.Rows[e.RowIndex];
                //Validacion para cuando se vuelve a clickear luego de que ya se pagó. No ejecuta el pago nuevamente.
                if (row.Cells["FechaHoraPago"].Value is not null)
                {
                    MessageBox.Show("Este servicio ya ha sido pagado.");
                    return;
                }

                int idAtencion;
                if (int.TryParse(dgvAtenciones.Rows[e.RowIndex].Cells["AtencionId"].Value?.ToString(), out idAtencion))
                {
                    RegistrarPago confirmarPagoForm = new RegistrarPago();
                    confirmarPagoForm.ShowDialog();
                    if (confirmarPagoForm.banderaDeConfirmacion)
                    {
                        DateTime fechaHoraActual = DateTime.Now;
                        dgvAtenciones.Rows[e.RowIndex].Cells["FechaHoraPago"].Value = fechaHoraActual;
                        await AtencionLogic.RegistrarPago(idAtencion, fechaHoraActual);
                        MessageBox.Show("Pago registrado con éxito");
                    }

                }

            }
        }


        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDniCliente.Text);
            var atencionesCliente = await AtencionLogic.GetAtencionesCliente(dni);
            dgvAtenciones.DataSource = atencionesCliente.ToList();
        }

        

        private async void BtnBorrarFiltro_Click_1(object sender, EventArgs e)
        {
            SetupDataGridViewColumns();
        }
    }
}