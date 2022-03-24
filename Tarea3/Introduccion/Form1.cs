namespace Introduccion;

public partial class Form1 : Form
{
    ComboBox? cmbFigura;
    ComboBox? cmbCalculo;
    Label? lblAltura;
    TextBox? txtAltura;
    Label? lblBase;
    TextBox? txtBase;
    Label? lblladoA;
    TextBox? txtladoA;
    Label? lblladoB;
    TextBox? txtladoB;
    TextBox? txtResult;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes(){
        this.Size = new Size(300,350);
        Label lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10,10);
        this.Controls.Add(lblFigura);

        cmbFigura = new ComboBox();
        cmbFigura.Items.Add("Cuadrado");
        cmbFigura.Items.Add("Rectangulo");
        cmbFigura.Items.Add("Triangulo");
        cmbFigura.Location = new Point(10,40);
        cmbFigura.SelectedValueChanged+= new EventHandler(cmbFiguras_ValueChanged);
        this.Controls.Add(cmbFigura);

        Label lblCalculo = new Label();
        lblCalculo.Text = "Calculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150,10);
        this.Controls.Add(lblCalculo);

        cmbCalculo = new ComboBox();
        cmbCalculo.Items.Add("Perimetro");
        cmbCalculo.Items.Add("Area");
        cmbCalculo.Location = new Point(150,40);
        cmbCalculo.SelectedValueChanged+= new EventHandler(cmbFiguras_ValueChanged);
        this.Controls.Add(cmbCalculo);

        lblAltura = new Label();
        lblAltura.Text = "Altura";
        lblAltura.AutoSize = true;
        lblAltura.Location = new Point(10,80);
        lblAltura.Visible = false;
        this.Controls.Add(lblAltura);

        txtAltura = new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location = new Point(60,75);
        txtAltura.Visible = false;
        this.Controls.Add(txtAltura);

        lblladoA = new Label();
        lblladoA.Text = "Lado A";
        lblladoA.AutoSize = true;
        lblladoA.Location = new Point(10,160);
        lblladoA.Visible = false;
        this.Controls.Add(lblladoA);

        txtladoA = new TextBox();
        txtladoA.Size = new Size(100,20);
        txtladoA.Location = new Point(60,155);
        txtladoA.Visible = false;
        this.Controls.Add(txtladoA);

        lblladoB = new Label();
        lblladoB.Text = "Lado B";
        lblladoB.AutoSize = true;
        lblladoB.Location = new Point(10,200);
        lblladoB.Visible = false;
        this.Controls.Add(lblladoB);

        txtladoB = new TextBox();
        txtladoB.Size = new Size(100,20);
        txtladoB.Location = new Point(60,195);
        txtladoB.Visible = false;
        this.Controls.Add(txtladoB);

        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize = true;
        lblBase.Location = new Point(10,120);
        lblBase.Visible = false;
        this.Controls.Add(lblBase);

        txtBase = new TextBox();
        txtBase.Size = new Size(100,20);
        txtBase.Location = new Point(60,115);
        txtBase.Visible = false;
        this.Controls.Add(txtBase);

        Button calcular = new Button();
        calcular.Text = "Calcular";
        calcular.AutoSize = true;
        calcular.Click+= new EventHandler(operacionBtn);
        calcular.Location = new Point(170,200);
        
        this.Controls.Add(calcular);

        Label lblResult = new Label();
        lblResult.Text = "Resultado";
        lblResult.AutoSize = true;
        lblResult.Location = new Point(10,280);
        this.Controls.Add(lblResult);

        txtResult = new TextBox();
        txtResult.Size = new Size(100,20);
        txtResult.Location = new Point(70,275);
        this.Controls.Add(txtResult);
    }

    private void cmbFiguras_ValueChanged(object sender, EventArgs e){
        if (cmbCalculo.SelectedItem!= null && cmbFigura.SelectedItem!=null){
            if (cmbFigura.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Perimetro"){
            txtAltura.Visible = true;
            lblAltura.Visible = true;
            lblBase.Visible = false;
            txtBase.Visible = false;
            txtladoA.Visible = false;
            lblladoA.Visible = false;
            txtladoB.Visible = false;
            lblladoB.Visible = false;
        }else{
                if (cmbFigura.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Area"){
                    txtAltura.Visible = true;
                    lblAltura.Visible = true;
                    lblBase.Visible = false;
                    txtBase.Visible = false;
                    txtladoA.Visible = false;
                    lblladoA.Visible = false;
                    txtladoB.Visible = false;
                    lblladoB.Visible = false;
                }else{
                    if (cmbFigura.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Area"){
                        txtAltura.Visible = true;
                        txtBase.Visible = true;
                        lblBase.Visible = true;
                        lblAltura.Visible = true;
                        txtladoA.Visible = false;
                        lblladoA.Visible = false;
                        txtladoB.Visible = false;
                        lblladoB.Visible = false;
                    }else{
                        if (cmbFigura.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Perimetro"){
                            txtAltura.Visible = true;
                            txtBase.Visible = true;
                            lblBase.Visible = true;
                            lblAltura.Visible = true;
                            txtladoA.Visible = false;
                            lblladoA.Visible = false;
                            txtladoB.Visible = false;
                            lblladoB.Visible = false;

                        }
                        else{
                            if (cmbFigura.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Area"){
                                txtAltura.Visible = true;
                                txtBase.Visible = true;
                                lblBase.Visible = true;
                                lblAltura.Visible = true;
                                txtladoA.Visible = false;
                                lblladoA.Visible = false;
                                txtladoB.Visible = false;
                                lblladoB.Visible = false;
                            }else{
                                if (cmbFigura.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Perimetro"){
                                    txtAltura.Visible = false;
                                    txtBase.Visible = true;
                                    lblBase.Visible = true;
                                    lblAltura.Visible = false;
                                    txtladoA.Visible = true;
                                    lblladoA.Visible = true;
                                    txtladoB.Visible = true;
                                    lblladoB.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void operacionBtn(object sender, EventArgs e){
        if (cmbCalculo.SelectedItem!= null && cmbFigura.SelectedItem!=null){
            if (cmbFigura.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString()== "Area"){
                if (txtAltura.Text!=null){
                    try{
                        double altura = double.Parse(txtAltura.Text);
                        txtResult.Text = (altura*altura).ToString();
                    }catch(Exception){
                    }
                }
            }else{
                if(cmbFigura.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString()== "Perimetro"){
                    if (txtAltura.Text!=null){
                        try{
                            double altura = double.Parse(txtAltura.Text);
                            txtResult.Text = (altura*4).ToString();
                        }catch(Exception){
                        }
                   }
                }else{
                    if(cmbFigura.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString()== "Perimetro"){
                        if (txtAltura.Text!=null && txtBase.Text!=null){
                            try{
                                double altura = double.Parse(txtAltura.Text);
                                double Base = double.Parse(txtBase.Text);
                                txtResult.Text = ((altura+Base)*2).ToString();
                            }catch(Exception){
                            }
                        }
                    }else{
                        if(cmbFigura.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString()== "Area"){
                            if (txtAltura.Text!=null && txtBase.Text!=null){
                               try{
                                    double altura = double.Parse(txtAltura.Text);
                                    double Base = double.Parse(txtBase.Text);
                                    txtResult.Text = (altura*Base).ToString();
                                }catch(Exception){
                                }
                            }
                        }else{
                            if(cmbFigura.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString()== "Area"){
                                try{
                                    double altura = double.Parse(txtAltura.Text);
                                    double Base = double.Parse(txtBase.Text);
                                    txtResult.Text = ((altura*Base)/2).ToString();
                                }catch(Exception){
                                }
                            }else{
                                if(cmbFigura.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString()== "Perimetro"){
                                    try{
                                        double altura = double.Parse(txtAltura.Text);
                                        double Base = double.Parse(txtBase.Text);
                                        double ladoa = double.Parse(txtladoA.Text);
                                        double ladob = double.Parse(txtladoB.Text);
                                        txtResult.Text = (ladoa+ladob+Base).ToString();
                                    }catch(Exception){
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
