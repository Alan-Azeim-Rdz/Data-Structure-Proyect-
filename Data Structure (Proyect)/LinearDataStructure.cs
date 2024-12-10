using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data_Structure__Proyect_
{
    public partial class LinearDataStructure : Form
    {
        public LinearDataStructure()
        {
            InitializeComponent();
        }
        QueueStatic queueStatic;
        CircularQueueStatic circularQueueStatic;

        private void ComboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (ComboBoxSelection.SelectedIndex)
                {
                    case 0:
                        ComboBoxList.Enabled = true;
                        ComboBoxStack.Enabled = false;
                        ComboBoxQueuetype.Enabled = false;
                        ComboBoxQueue.Enabled = false;
                        break;
                    case 1:
                        ComboBoxList.Enabled = false;
                        ComboBoxStack.Enabled = true;
                        ComboBoxQueuetype.Enabled = false;
                        ComboBoxQueue.Enabled = false;
                        break;

                    case 2:
                        ComboBoxList.Enabled = false;
                        ComboBoxStack.Enabled = false;
                        ComboBoxQueuetype.Enabled = true;
                        ComboBoxQueue.Enabled = true;
                        break;
                }
            }
            catch { MessageBox.Show("Selecciona una opcion valida"); }
        }





        private void BtnSizeVector_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(TextSizeVector.Text);
                string selection = CheckComboBoxes();


                if (selection == "ComboBoxQueue" && ComboBoxQueuetype.SelectedItem.ToString() == "Vector")
                {
                    string selectionCheck = ComboBoxQueue.SelectedItem.ToString();
                    string selectionCheck2 = ComboBoxQueuetype.SelectedItem.ToString();
                    if (selectionCheck == "Simples")
                    {
                        queueStatic = new QueueStatic(size);
                    }
                    if (selectionCheck == "Circulares")
                    {
                        circularQueueStatic = new CircularQueueStatic(size);
                    }
                    if (selectionCheck == "Dobles")
                    {

                    }
                    if (selectionCheck == "Prioridad")
                    {


                    }

                }
                if (selection == "ComboBoxStack")
                {
                    string selectionCheck = ComboBoxStack.SelectedItem.ToString();
                }





            }
            catch { MessageBox.Show("complete los datos"); }
        }

        private void BtnAddNumber_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddNumberQueue_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(TextNumberAdd.Text);

            string selectionCheck = ComboBoxQueue.SelectedItem.ToString();
            string selectionCheck2 = ComboBoxQueuetype.SelectedItem.ToString();

            if(selectionCheck == "Simples" && selectionCheck2 == "Vectores")
            {
                if (!(queueStatic.IsFull()))
                {
                    queueStatic.Enqueue(number);
                    foreach (int num in queueStatic)
                    {
                        ListViewData.Items.Add(Convert.ToString(num));
                    }
                    return;
                }
                MessageBox.Show("No puedes agregar mas datos");
            }
            if (selectionCheck == "Circulares" && selectionCheck2 == "Vectores")
            {
                CircularQueueStatic queueStatic = new CircularQueueStatic(number);
            }
            if(selectionCheck == "Dobles" && selectionCheck2 == "Vectores")
            {

            }
            if(selectionCheck == "Prioridad" && selectionCheck2 == "Vectores")
            {
            }
        }


        private string CheckComboBoxes()
        {
            // Variable para almacenar el resultado
            string result = "";

            // Recorre todos los controles del formulario
            foreach (Control control in this.Controls)
            {
                if (!(control.Name == ComboBoxSelection.Name))
                {
                    // Verifica si el control es un ComboBox
                    if (control is ComboBox comboBox)
                    {
                        // Verifica si el ComboBox está habilitado
                        if (comboBox.Enabled)
                        {
                            // Añade el nombre y el valor seleccionado del ComboBox habilitado
                            result += comboBox.Name + " " + comboBox.SelectedItem?.ToString();
                        }
                    }
                }
            }

            // Si no se encontró ningún ComboBox habilitado, mostrar mensaje
            if (string.IsNullOrEmpty(result))
            {
                result = "No existe ningún ComboBox habilitado o seleccionado.";
            }

            return result;
        }

        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextSizeVector.Enabled = false;
            BtnSizeVector.Enabled = false;
        }

       
    }
}
