using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Librerias necesarias para la serializacion
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //Para comvertir los textos en binarios

namespace pjSerializacionTextoMemo
{
    public partial class frmSerializa : Form
    {
        public frmSerializa()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            //Objeto de la clase FileDialog
            SaveFileDialog sv = new SaveFileDialog();
            //Definiendo el tipo de archivo
            sv.Filter = "Archivo Binario|*.bin";
            //Mostrando el cuadro de dialogo de grabacion
            if (sv.ShowDialog() == DialogResult.OK)
            {
                //Creando el archivo
                using(FileStream fs = new FileStream(sv.FileName,FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, txtCadena.Text);
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            //Objeto de la clase opendialog
            OpenFileDialog op = new OpenFileDialog();
            //Definiendo el tipo de filtro
            op.Filter = "Archivo Binario|*.bin";
            //Mostrando el acuadro de dialogo abrir
            if (op.ShowDialog() == DialogResult.OK)
            {
                //Abriendo el archivo
                using (FileStream fs = new FileStream(op.FileName, FileMode.Open))
                {
                    //Convirtiendo el binario en archivo de texto
                    BinaryFormatter bf = new BinaryFormatter();
                    txtCadena.Text = bf.Deserialize(fs).ToString();

                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Clear();
        }
    }
}
