using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelViewer.Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            excelViewer1.OpenFile(@"C:\Users\Fuentes\Google Drive (vfjhovanyitsolutions@gmail.com)\COSTOS Y UTILIDADES\TIENDA JOSE GERARDO\CUADRO DE UTILIDADES JG 2018.xlsx");
        }
    }
}
