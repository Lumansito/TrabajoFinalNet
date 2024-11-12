using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views.Desktop.Menu
{
    internal class MenuSecretario
    {

        public MenuStrip CreateMenu(Form mdiParent)
        {

            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem menuCliente = new ToolStripMenuItem("Clientes");

            ToolStripMenuItem menuCliente_Item1 = new ToolStripMenuItem("Gestión de Clientes");
            menuCliente_Item1.Click += (sender, e) => { CrudClientes menuCrudCliente = new CrudClientes(mdiParent); menuCrudCliente.Show(); };

            ToolStripMenuItem menuCliente_Item3 = new ToolStripMenuItem("Gestion de Mascotas");
            menuCliente_Item3.Click += (sender, e) => { GestionDeMascotas gestionDeMascotas = new GestionDeMascotas(mdiParent); gestionDeMascotas.Show(); };

            ToolStripMenuItem menuCliente_Item4 = new ToolStripMenuItem("Atenciones Realizadas");
            menuCliente_Item4.Click += (sender, e) => {
                //AtencionesRealizadas menuAtencionesRealizadas = new AtencionesRealizadas();
                //menuAtencionesRealizadas.MdiParent = mdiParent;
                //menuAtencionesRealizadas.Show();
            };

            ToolStripMenuItem menuCliente_Item5 = new ToolStripMenuItem("Membresias");
            menuCliente_Item5.Click += (sender, e) => { MembresiasCliente menuMembresia = new MembresiasCliente(mdiParent); menuMembresia.Show(); };

            menuCliente.DropDownItems.Add(menuCliente_Item1);
            //menuCliente.DropDownItems.Add(menuCliente_Item2);
            menuCliente.DropDownItems.Add(menuCliente_Item3);
            menuCliente.DropDownItems.Add(menuCliente_Item4);
            menuCliente.DropDownItems.Add(menuCliente_Item5);

            // Agregar el menú Clientes al MenuStrip
            menuStrip.Items.Add(menuCliente);

            // Crear y agregar el menú de Turnos
            ToolStripMenuItem menuTurnos = new ToolStripMenuItem("Gestion Turnos");
            ToolStripMenuItem menuTurnos_Item1 = new ToolStripMenuItem("Nuevo Turno");
            menuTurnos_Item1.Click += (sender, e) => { CreateTurno menuAltaTurno = new CreateTurno(mdiParent); menuAltaTurno.Show(); };
            ToolStripMenuItem menuTurnos_Item2 = new ToolStripMenuItem("Historial Turnos");

            menuTurnos.DropDownItems.Add(menuTurnos_Item1);
            menuTurnos.DropDownItems.Add(menuTurnos_Item2);

            menuStrip.Items.Add(menuTurnos);

            return menuStrip;

        }

    }
}
