using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Threading;
using System.Globalization;

namespace nuevaEtiqueta
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        //Diccionarios
        Dictionary<string, string> etProductor = new Dictionary<string, string>();
        Dictionary<string, string> etVariedades = new Dictionary<string, string>();
        Dictionary<string, string> etEspecie = new Dictionary<string, string>();
        //Dictionary<string, string> etAcopio = new Dictionary<string, string>();

        Boolean estado;
        private Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            //this.getPrinters();   IMPRESORAS
            eliminarArchivos();   
            cargarXML(); 
        }


        public void cargarXML()
        {
            estado = true;

            if (!File.Exists(@"C:\temp\productor.xml"))
            {
                try
                {
                    File.Copy(Application.StartupPath + @"\productor.xml", @"C:\temp\productor.xml");
                    //crear carpeta
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error : "+ ex);
                    estado = false;

                }
            }
            if (estado == true)
            {

                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                doc.Load(@"C:\temp\productor.xml");

                //Productor
                XmlNodeList nodoProductor = doc.GetElementsByTagName("productores");
                foreach (XmlNode node in nodoProductor[0].ChildNodes)
                {
                    etProductor.Add(node.Attributes["id"].Value, node.InnerXml);

                }
                //Variedad

                XmlNodeList nodoVariedades = doc.GetElementsByTagName("variedades");
                foreach (XmlNode node in nodoVariedades[0].ChildNodes)
                {
                    etVariedades.Add(node.Attributes["idm"].Value, node.InnerText);

                }
                comboVariedad.DataSource = new BindingSource(etVariedades, null);
                comboVariedad.DisplayMember = "Value";
                comboVariedad.ValueMember = "Key";

                //Especie

                XmlNodeList nodoEspecie = doc.GetElementsByTagName("especies");
                foreach (XmlNode node in nodoEspecie[0].ChildNodes)
                {
                    etEspecie.Add(node.Attributes["id"].Value, node.InnerText);
                }
                comboEspecie.DataSource = new BindingSource(etEspecie, null);
                comboEspecie.DisplayMember = "value";
                comboEspecie.ValueMember = "key";
            }
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //crear codigo barra
        }

        private void txtProductor_TextChanged(object sender, EventArgs e)
        {
            if (etProductor.ContainsKey(txtProductor.Text))
            {
                string productor = "<datos>" + etProductor[txtProductor.Text] + "</datos>";

                XmlDocument doc = new XmlDocument();
                String s = "hello";
                doc.LoadXml(String.Format(productor, s));

                XmlNodeList nodoNombre = doc.GetElementsByTagName("nombre");
                XmlNodeList nodoCod = doc.GetElementsByTagName("cod");

                lblNomProductor.Text = nodoNombre.Item(0).InnerText;
                lblCodProductor.Text = nodoCod.Item(0).InnerText;

                //CREAR CODIGO BARRA
            }



        }

        private void comboVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> variedad = (KeyValuePair<string, string>)comboVariedad.SelectedItem;
            
            if (variedad.Value.ToString() != "Seleccione")
            {
                lblVariedad.Text = variedad.Value.ToString();
            }

            //crear codigo barra
        }

        private void comboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> especie = (KeyValuePair<string, string>)comboEspecie.SelectedItem;

            if (especie.Value.ToString() != "Seleccion")
            {
                lblEspecie.Text = especie.Value.ToString();
            }

            //crear codigo barra
        }



        //elimina archivos de la carpeta C:\temp
        private void eliminarArchivos()
        {
            string[] ficherosCarpeta = Directory.GetFiles(@"c:\temp");
            foreach (string ficheroActual in ficherosCarpeta)
                File.Delete(ficheroActual);
        }
    }
}
