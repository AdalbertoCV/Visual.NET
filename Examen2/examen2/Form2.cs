namespace examen2;

public partial class Form2 : Form
{
    public String monedaC;
    public CheckBox cbUS;
    public CheckBox cbMX;
    public CheckBox cbCAD;
    public CheckBox cbEUR;
    public CheckBox cbYN;
    public List<CheckBox> checkboxes;

    public Label lblUS;
    public Label lblMX;
    public Label lblCAD;
    public Label lblEUR;
    public Label lblYN;
    public Button btnAceptar;
    public Button btnCancelar;

    public List<Label> labels;
    public List<String> conversiones;
    public Form2(String moneda)
    {
        monedaC = moneda;
        cbUS = new CheckBox();
        cbMX = new CheckBox();
        cbCAD = new CheckBox();
        cbEUR = new CheckBox();
        cbYN = new CheckBox();
        lblUS = new Label();
        lblMX = new Label();
        lblCAD = new Label();
        lblEUR = new Label();
        lblYN = new Label();
        checkboxes = new List<CheckBox>();
        labels = new List<Label>();
        conversiones = new List<string>();
        btnAceptar = new Button();
        btnCancelar = new Button();
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size = new Size(500,250);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Text = "Seleccionar Conversiones";
        lblCAD.Text = "CAD - Dólar canadiense";
        lblUS.Text = "USD - Dólar estadounidense";
        lblMX.Text = "MXN - Peso mexicano";
        lblEUR.Text = "EUR - Euro";
        lblYN.Text = "JPY - Yen japonés";
        lblCAD.AutoSize = true;
        lblEUR.AutoSize = true;
        lblMX.AutoSize = true;
        lblUS.AutoSize = true;
        lblYN.AutoSize = true;
        verificarMoneda(this.monedaC);
        btnAceptar.Text = "Aceptar";
        btnAceptar.Click += new EventHandler(btnAceptar_click);
        btnAceptar.AutoSize = true;
        btnAceptar.Location = new Point(150,180);
        btnCancelar.Text = "Cancelar";
        btnCancelar.Click += new EventHandler(btnCancelar_click);
        btnCancelar.AutoSize = true;
        btnCancelar.Location = new Point(10,180);
        this.Controls.Add(btnAceptar);
        this.Controls.Add(btnCancelar);
    }

    private void btnAceptar_click(object? sender, EventArgs e){
        this.DialogResult =  DialogResult.OK;
        this.Close();
    }

    private void btnCancelar_click(object? sender, EventArgs e){
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void verificarMoneda(String mon)
    {
        if (mon.Equals("MXN")){
            cbUS.Location = new Point (10,10);
            lblUS.Location = new Point (150,10);
            cbCAD.Location = new Point (10,40);
            lblCAD.Location = new Point (150,40);
            cbEUR.Location = new Point (10,70);
            lblEUR.Location = new Point (150,70);
            cbYN.Location = new Point (10,100);
            lblYN.Location = new Point (150,100);
            this.Controls.Add(cbUS);
            this.Controls.Add(lblUS);
            this.Controls.Add(cbCAD);
            this.Controls.Add(lblCAD);
            this.Controls.Add(cbEUR);
            this.Controls.Add(lblEUR);
            this.Controls.Add(cbYN);
            this.Controls.Add(lblYN);
        }else{
            if (mon.Equals("USD")){
                cbMX.Location = new Point (10,10);
                lblMX.Location = new Point (150,10);
                cbCAD.Location = new Point (10,40);
                lblCAD.Location = new Point (150,40);
                cbEUR.Location = new Point (10,70);
                lblEUR.Location = new Point (150,70);
                cbYN.Location = new Point (10,100);
                lblYN.Location = new Point (150,100);
                this.Controls.Add(cbMX);
                this.Controls.Add(lblMX);
                this.Controls.Add(cbCAD);
                this.Controls.Add(lblCAD);
                this.Controls.Add(cbEUR);
                this.Controls.Add(lblEUR);
                this.Controls.Add(cbYN);
                this.Controls.Add(lblYN);
            }else{
                if (mon.Equals("CAD")){
                    cbUS.Location = new Point (10,10);
                    lblUS.Location = new Point (150,10);
                    cbMX.Location = new Point (10,40);
                    lblMX.Location = new Point (150,40);
                    cbEUR.Location = new Point (10,70);
                    lblEUR.Location = new Point (150,70);
                    cbYN.Location = new Point (10,100);
                    lblYN.Location = new Point (150,100);
                    this.Controls.Add(cbUS);
                    this.Controls.Add(lblUS);
                    this.Controls.Add(cbMX);
                    this.Controls.Add(lblMX);
                    this.Controls.Add(cbEUR);
                    this.Controls.Add(lblEUR);
                    this.Controls.Add(cbYN);
                    this.Controls.Add(lblYN);
                }else{
                    if (mon.Equals("EUR")){
                        cbUS.Location = new Point (10,10);
                        lblUS.Location = new Point (150,10);
                        cbCAD.Location = new Point (10,40);
                        lblCAD.Location = new Point (150,40);
                        cbMX.Location = new Point (10,70);
                        lblMX.Location = new Point (150,70);
                        cbYN.Location = new Point (10,100);
                        lblYN.Location = new Point (150,100);
                        this.Controls.Add(cbUS);
                        this.Controls.Add(lblUS);
                        this.Controls.Add(cbCAD);
                        this.Controls.Add(lblCAD);
                        this.Controls.Add(cbMX);
                        this.Controls.Add(lblMX);
                        this.Controls.Add(cbYN);
                        this.Controls.Add(lblYN);
                    }else{
                        if (mon.Equals("JPY")){
                            cbUS.Location = new Point (10,10);
                            lblUS.Location = new Point (150,10);
                            cbCAD.Location = new Point (10,40);
                            lblCAD.Location = new Point (150,40);
                            cbEUR.Location = new Point (10,70);
                            lblEUR.Location = new Point (150,70);
                            cbMX.Location = new Point (10,100);
                            lblMX.Location = new Point (150,100);
                            this.Controls.Add(cbUS);
                            this.Controls.Add(lblUS);
                            this.Controls.Add(cbCAD);
                            this.Controls.Add(lblCAD);
                            this.Controls.Add(cbEUR);
                            this.Controls.Add(lblEUR);
                            this.Controls.Add(cbMX);
                            this.Controls.Add(lblMX);
                        }
                    }
                }
            }
        }
    }
}
