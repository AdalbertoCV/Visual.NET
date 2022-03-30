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
        private Button btnPi;
        private Button btnlog;
        private Button btnsqrt;
        private Button btnCuadrado;
        private Button btnSinh;
        private Button btnSin;
        private Button btnDec;
        private Button btnCosh;
        private Button btnXy;
        private Button btnCos;
        private Button btnBin;
        private Button btn1X;
        private Button btnTanh;
        private Button btnTan;
        private Button btnHex;
        private Button btnLnx;
        private Button btnExp;
        private Button btnMod;
        private Button btnOct;
        private TextBox txtDisplay;
        private Label lblOperacion;
        private String operacion;
        private Double resultado;
        private ComboBox? cmbMenu;
        private Label lblMenu;

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
            btnPi = new Button();
            btnlog= new Button();
            btnsqrt= new Button();
            btnCuadrado= new Button();
            btnSinh= new Button();
            btnSin= new Button();
            btnDec= new Button();
            btnCosh= new Button();
            btnXy= new Button();
            btnCos= new Button();
            btnBin= new Button();
            btn1X= new Button();
            btnTanh= new Button();
            btnTan= new Button();
            btnHex= new Button();
            btnLnx= new Button();
            btnExp= new Button();
            btnMod= new Button();
            btnOct= new Button();
            cmbMenu = new ComboBox();
            lblMenu = new Label();
            InitializeComponent();
            InicializarComponentes();
        }

        private void Menu_Seleccion(object? sender, EventArgs e)
        {
            if (cmbMenu.SelectedItem!="Cientifica"){
                this.Size = new Size (300,500);
                txtDisplay.Size = new Size(270, 50);
            }else{
                this.Size = new Size (600,500);
                txtDisplay.Size = new Size(570, 50);
            }
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(300, 500);
            this.Text = "Calculadora";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            lblMenu.Text = "Seleccionar Tipo Calculadora";
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(10,5);
            this.Controls.Add(lblMenu);
            cmbMenu.Items.Add("Basica");
            cmbMenu.Items.Add("Cientifica");
            cmbMenu.Location = new Point(10,20);
            cmbMenu.SelectedValueChanged+= new EventHandler(Menu_Seleccion);
            this.Controls.Add(cmbMenu);
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
            btnPi.Size = new Size(60, 60);
            btnlog.Size = new Size(60, 60);
            btnsqrt.Size = new Size(60, 60);
            btnCuadrado.Size = new Size(60, 60);
            btnSinh.Size = new Size(60, 60);
            btnSin.Size = new Size(60, 60);
            btnDec.Size = new Size(60, 60);
            btnCosh.Size = new Size(60, 60);
            btnXy.Size = new Size(60, 60);
            btnCos.Size = new Size(60, 60);
            btnBin.Size = new Size(60, 60);
            btn1X.Size = new Size(60, 60);
            btnTanh.Size = new Size(60, 60);
            btnTan.Size = new Size(60, 60);
            btnHex.Size = new Size(60, 60);
            btnLnx.Size = new Size(60, 60);
            btnExp.Size = new Size(60, 60);
            btnMod.Size = new Size(60, 60);
            btnOct.Size = new Size(60, 60);
            txtDisplay.Size = new Size(270, 50);
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
            btnPi.Text = "π";
            btnlog.Text = "Log";
            btnsqrt.Text = "sqrt";
            btnCuadrado.Text = "^";
            btnSinh.Text = "Sinh";
            btnSin.Text = "Sin";
            btnDec.Text = "Dec";
            btnCosh.Text = "Cosh";
            btnCos.Text = "Cos";
            btnXy.Text = "X^Y";
            btnBin.Text = "Bin";
            btn1X.Text = "1/X";
            btnTanh.Text = "Tanh";
            btnTan.Text = "Tan";
            btnHex.Text = "Hex";
            btnLnx.Text = "Lnx";
            btnExp.Text = "Exp";
            btnMod.Text = "%";
            btnOct.Text = "Oct";

            // Posicion
            txtDisplay.Location = new Point(10, 50);
            lblOperacion.Location = new Point(10, 50);

            List<Button> lista = new List<Button>();
            List<Button> Cientifica = new List<Button>();
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
            Cientifica.Add(btnPi);
            Cientifica.Add(btnlog);
            Cientifica.Add(btnsqrt);
            Cientifica.Add(btnCuadrado);
            Cientifica.Add(btnSinh);
            Cientifica.Add(btnSin);
            Cientifica.Add(btnDec);
            Cientifica.Add(btnCosh);
            Cientifica.Add(btnCos);
            Cientifica.Add(btnXy);
            Cientifica.Add(btnBin);
            Cientifica.Add(btn1X);
            Cientifica.Add(btnTanh);
            Cientifica.Add(btnTan);
            Cientifica.Add(btnHex);
            Cientifica.Add(btnLnx);
            Cientifica.Add(btnExp);
            Cientifica.Add(btnMod);
            Cientifica.Add(btnOct);
        
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            
            int x = 10;
            int y = 105;
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

            x = 300;
            y = 105;
            count = 0;
            foreach (Button btn in Cientifica)
            {
                if (count == 4)
                {
                    x = 300;
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
                        if (txtDisplay.Text != ""){
                            txtDisplay.Text = (Double.Parse(txtDisplay.Text)* -1).ToString();
                        }
                        break;
                    case "0": case "1": case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9": case ".":
                        boton_numero(btn.Text);
                        break;
                    case "+": case "-": case "*": case "/":
                        boton_numero_operador(btn.Text);
                        break;
                    case "π":
                        txtDisplay.Text = "3.1416";
                        break;
                    case "Log":
                        btn_log(txtDisplay.Text);
                        break;
                    case "sqrt":
                        btn_sqrt(txtDisplay.Text);
                        break;
                    case "^":
                        btn_cuadrado(txtDisplay.Text);
                        break;
                    case "Sinh":
                        btn_sinh(txtDisplay.Text);
                        break;
                    case "Sin":
                        btn_sin(txtDisplay.Text);
                        break;
                    case "Dec":
                        btn_dec(txtDisplay.Text);
                        break;
                    case "Cosh":
                        btn_cosh(txtDisplay.Text);
                        break;
                    case "Cos":
                        btn_cos(txtDisplay.Text);
                        break;
                    case "X^Y":
                        boton_numero_operador(btn.Text);
                        break;
                    case "Bin":
                        boton_bin(txtDisplay.Text);
                        break;
                    case "1/X":
                        btn_divuno(txtDisplay.Text);
                        break;
                    case "Tanh":
                        btn_tanh(txtDisplay.Text);
                        break;
                    case "Tan":
                        btn_tan(txtDisplay.Text);
                        break;
                    case "Hex":
                        btn_hex(txtDisplay.Text);
                        break;
                    case "Lnx":
                        btn_lnx(txtDisplay.Text);
                        break;
                    case "Exp":
                        btn_exp(txtDisplay.Text);
                        break;
                    case "%":
                        boton_numero_operador(btn.Text);
                        break;
                    case "Oct":
                        btn_oct(txtDisplay.Text);
                        break;
                }
            }
        }

        private void btn_exp(string text)
        {
            try{
                txtDisplay.Text = Math.Exp(Double.Parse(text)).ToString();
            }catch(Exception){
            }
        }

        private void btn_oct(string text)
        {
            try{
                int numero = int.Parse(text);
                txtDisplay.Text = Convert.ToString(numero,8);
            }catch(Exception){
            }
        }

        private void btn_hex(string text)
        {
            try{
                int numero = int.Parse(text);
                txtDisplay.Text = Convert.ToString(numero,16);
            }catch(Exception){
            }
        }

        private void btn_dec(string text)
        {
            try{
                txtDisplay.Text = Convert.ToInt32(text, 16).ToString();
            }catch(Exception){
            }
        }

        private void btn_lnx(string text)
        {
            try{
                txtDisplay.Text = Math.Log2(Double.Parse(text)).ToString();
            }catch(Exception){
            }
        }

        private void btn_tanh(string text)
        {
            try{
                txtDisplay.Text = Math.Tanh(Double.Parse(text)).ToString();
            }catch(Exception){
            }
        }

        private void btn_tan(string text)
        {
            try{
                txtDisplay.Text = Math.Tan(Double.Parse(text)).ToString();
            }catch(Exception){
            }
        }

        private void btn_divuno(string text)
        {
            try{
                txtDisplay.Text = (1/ Double.Parse(text)).ToString();
            }catch(Exception){
            }
        }

        private void boton_bin(string text)
        {
            try{
                int numero = int.Parse(text);
                txtDisplay.Text = Convert.ToString(numero,2);
            }catch(Exception){
            }
        }

        private void btn_cos(string text)
        {
            try{
                if (text!="" || text!="."){
                txtDisplay.Text = Math.Cos(Double.Parse(text)).ToString();
            }
            }catch(Exception){
            }
        }

        private void btn_cosh(string text)
        {
            try{
                if (text!="" || text!="."){
                txtDisplay.Text = Math.Cosh(Double.Parse(text)).ToString();
            }
            }catch(Exception){
            }
        }

        private void btn_sin(string text)
        {
            try{
                if (text!=""|| text!="."){
                txtDisplay.Text = Math.Sin(Double.Parse(text)).ToString();
            }
            }catch(Exception){
            }
        }

        private void btn_sinh(string text)
        {
            try{
                if (text!=""|| text!="."){
                txtDisplay.Text = Math.Sinh(Double.Parse(text)).ToString();
            }
            }catch(Exception){
            }
        }

        private void btn_cuadrado(string text)
        {
            try{
                if (text!=""|| text!="."){
                txtDisplay.Text = Math.Pow(Double.Parse(text),2).ToString();
            }
            }catch(Exception){
            }
        }

        private void btn_sqrt(string text)
        {
            try{
                if (text!=""|| text!="."){
                txtDisplay.Text = Math.Sqrt(Double.Parse(text)).ToString();
            }
            }catch(Exception){
            }
        }

        private void btn_log(string text)
        {
            try{
                if (text!=""|| text!="."){
                txtDisplay.Text = Math.Log(Double.Parse(text)).ToString();
            }
            }catch(Exception){
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
                case "X^Y":
                    txtDisplay.Text = (Math.Pow(resultado , Double.Parse(txtDisplay.Text))).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (resultado % Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void boton_numero_operador(string operador)
        {
            try{
                operacion = operador;
                resultado = Double.Parse(txtDisplay.Text);
                lblOperacion.Text = txtDisplay.Text + " " + operacion;
                txtDisplay.Text = "0";
            }catch(Exception){
            }
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