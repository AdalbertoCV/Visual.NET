namespace CRUD;

public partial class Form1 : Form
{
    private CervezaContext bd;
    private DataGridView gdCervezas;
    private Button btnAgregar;
    private Button btnEditar;
    private Button btnEliminar;

    public Form1()
    {
        bd = new CervezaContext();
        gdCervezas = new DataGridView();
        btnAgregar = new Button();
        btnEditar = new Button();
        btnEliminar = new Button();
        InitializeComponent();
        inicializarComponentes();
    }

    private void inicializarComponentes()
    {
        gdCervezas.DataSource = bd.cervezas.ToList();
        this.Size = new Size(650,350);
        gdCervezas.Size = new Size(500,280);
        gdCervezas.Location = new Point(15,15);
        btnAgregar.AutoSize = true;
        btnEditar.AutoSize = true;
        btnEliminar.AutoSize = true;
        btnAgregar.Text = "Agregar";
        btnEditar.Text = "Editar";
        btnEliminar.Text = "Eliminar";
        btnAgregar.Location = new Point(530,15);
        btnEditar.Location = new Point(530,150);
        btnEliminar.Location = new Point(530,270);
        btnAgregar.Click+= btnAgregar_click;
        btnEditar.Click+= btnEditar_click;
        btnEliminar.Click+= btnEliminar_click;
        this.Controls.Add(gdCervezas);
        this.Controls.Add(btnAgregar);
        this.Controls.Add(btnEditar);
        this.Controls.Add(btnEliminar);
    }

    private void btnAgregar_click(object? sender, EventArgs e){
        Form2 nuevoForm = new Form2();
        if(nuevoForm.ShowDialog() == DialogResult.OK){
            bd.Add(nuevoForm.cerveza);
            bd.SaveChanges();
            gdCervezas.DataSource = bd.cervezas.ToList();
        }
    }

    private void btnEditar_click(object? sender, EventArgs e){
        cerveza seleccionada = (cerveza) gdCervezas.CurrentRow.DataBoundItem;
        Form2 editForm = new Form2(seleccionada);
        if(editForm.ShowDialog() == DialogResult.OK){
            bd.Update(editForm.cerveza);
            bd.SaveChanges();
            gdCervezas.DataSource = bd.cervezas.ToList();
        }
    }

    private void btnEliminar_click(object? sender, EventArgs e){
        cerveza seleccionada = (cerveza) gdCervezas.CurrentRow.DataBoundItem;
        bd.Remove(seleccionada);
        bd.SaveChanges();
        gdCervezas.DataSource = bd.cervezas.ToList();
    }
}
