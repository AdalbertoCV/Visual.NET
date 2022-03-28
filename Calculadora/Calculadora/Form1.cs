using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Button btnBorrarUltimo;
        private Button btnBorrarActual;
        private Button btnBorrarTodo;
        private Button btnSigno;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSuma;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnResta;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMultiplicacion;
        private Button btn0;
        private Button btnPunto;
        private Button btnIgual;
        private Button btnDivision;
        private TextBox txtDisplay;
        private Label lblOperacion;
        private String operacion;
        private Double resultado;

        public Form1()
        {
            operacion = "";
            resultado = 0;
            txtDisplay = new TextBox();
            lblOperacion = new Label();
            btnBorrarUltimo = new Button();
            btnBorrarActual = new Button();
            btnBorrarTodo = new Button();
            btnSigno = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnSuma = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnResta = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMultiplicacion = new Button();
            btn0 = new Button();
            btnPunto = new Button();
            btnIgual = new Button();
            btnDivision = new Button();
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(300, 500);
            this.Text = "Calculadora";
            // Tamaño botones
            btnBorrarUltimo.Size = new Size(60, 60);
            btnBorrarActual.Size = new Size(60, 60);
            btnBorrarTodo.Size = new Size(60, 60);
            btnSigno.Size = new Size(60, 60);
            btn7.Size = new Size(60, 60);
            btn8.Size = new Size(60, 60);
            btn9.Size = new Size(60, 60);
            btnSuma.Size = new Size(60, 60);
            btn4.Size = new Size(60, 60);
            btn5.Size = new Size(60, 60);
            btn6.Size = new Size(60, 60);
            btnResta.Size = new Size(60, 60);
            btn1.Size = new Size(60, 60);
            btn2.Size = new Size(60, 60);
            btn3.Size = new Size(60, 60);
            btnMultiplicacion.Size = new Size(60, 60);
            btn0.Size = new Size(60, 60);
            btnPunto.Size = new Size(60, 60);
            btnIgual.Size = new Size(60, 60);
            btnDivision.Size = new Size(60, 60);
            txtDisplay.Size = new Size(260, 50);
            txtDisplay.Multiline = true;
            lblOperacion.AutoSize = true;

            // Texto
            btnBorrarUltimo.Text = "⌫";
            btnBorrarActual.Text = "CE";
            btnBorrarTodo.Text = "C";
            btnSigno.Text = "±";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btnSuma.Text = "+";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btnResta.Text = "-";
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btnMultiplicacion.Text = "*";
            btn0.Text = "0";
            btnPunto.Text = ".";
            btnIgual.Text = "=";
            btnDivision.Text = "/";

            // Posicion
            txtDisplay.Location = new Point(10, 30);
            lblOperacion.Location = new Point(10, 30);

            List<Button> lista = new List<Button>();
            lista.Add(btnBorrarUltimo);
            lista.Add(btnBorrarActual);
            lista.Add(btnBorrarTodo);
            lista.Add(btnSigno);
            lista.Add(btn7);
            lista.Add(btn8);
            lista.Add(btn9);
            lista.Add(btnSuma);
            lista.Add(btn4);
            lista.Add(btn5);
            lista.Add(btn6);
            lista.Add(btnResta);
            lista.Add(btn1);
            lista.Add(btn2);
            lista.Add(btn3);
            lista.Add(btnMultiplicacion);
            lista.Add(btn0);
            lista.Add(btnPunto);
            lista.Add(btnIgual);
            lista.Add(btnDivision);
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            
            int x = 10;
            int y = 85;
            int count = 0;
            foreach (Button btn in lista)
            {
                if (count == 4)
                {
                    x = 10;
                    y += 67;
                    count = 0;
                }
                btn.Location = new Point(x, y);
                btn.Click += new EventHandler(btn_click);
                this.Controls.Add(btn);
                x += 67;
                count++;
            }

            // Agregar controles al formulario
            this.Controls.Add(txtDisplay);
            this.Controls.Add(lblOperacion);
            lblOperacion.BringToFront();
        }

        private void btn_click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Button btn = (Button)sender;
                switch (btn.Text)
                {
                    case "⌫":
                        if(txtDisplay.Text.Length > 0  )
                        {
                            // Se elimina el ultimo elemento de la cadena que esta hasta la derecha, el (, 1) indica que solo se elimina un elemento.
                            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                        }
                        if (txtDisplay.Text == "")
                        {
                            txtDisplay.Text = "0";
                        }
                        break;
                    case "CE":
                        txtDisplay.Text = "0";
                        break;
                    case "C":
                        txtDisplay.Text = "0";
                        lblOperacion.Text = "";
                        break;
                    case "=":
                        boton_igual();
                        break;
                    case "±":
                        txtDisplay.Text = (Double.Parse(txtDisplay.Text)* -1).ToString();
                        break;
                    case "0": case "1": case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9": case ".":
                        boton_numero(btn.Text);
                        break;
                    case "+": case "-": case "*": case "/":
                        boton_numero_operador(btn.Text);
                        break;
                }
            }
        }

        private void boton_igual()
        {
            lblOperacion.Text = " " + txtDisplay.Text + " =";
            switch (operacion)
            {
                case "+":
                    txtDisplay.Text = (resultado + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultado - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultado * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void boton_numero_operador(string operador)
        {
            operacion = operador;
            resultado = Double.Parse(txtDisplay.Text);
            lblOperacion.Text = txtDisplay.Text + " " + operacion;
            txtDisplay.Text = "0";
        }

        private void boton_numero(string valor)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            if(valor == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += valor;
                }
            }
            else
            {
                txtDisplay.Text += valor;
            }
        }
    }
}