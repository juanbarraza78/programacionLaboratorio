namespace i02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            l_nombre = new Label();
            l_direccion = new Label();
            l_edad = new Label();
            tb_nombre = new TextBox();
            tb_direccion = new TextBox();
            nud_edad = new NumericUpDown();
            gb_detallesUsuario = new GroupBox();
            rb_masculino = new RadioButton();
            rb_femenino = new RadioButton();
            rb_binario = new RadioButton();
            gb_genero = new GroupBox();
            gb_cursos = new GroupBox();
            cb_javaScript = new CheckBox();
            cb_cMas = new CheckBox();
            cb_c = new CheckBox();
            lb_pais = new ListBox();
            l_pais = new Label();
            btn_ingresar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_edad).BeginInit();
            gb_detallesUsuario.SuspendLayout();
            gb_genero.SuspendLayout();
            gb_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // l_nombre
            // 
            l_nombre.AutoSize = true;
            l_nombre.Location = new Point(0, 46);
            l_nombre.Name = "l_nombre";
            l_nombre.Size = new Size(54, 15);
            l_nombre.TabIndex = 0;
            l_nombre.Text = "Nombre:";
            // 
            // l_direccion
            // 
            l_direccion.AutoSize = true;
            l_direccion.Location = new Point(0, 82);
            l_direccion.Name = "l_direccion";
            l_direccion.Size = new Size(60, 15);
            l_direccion.TabIndex = 1;
            l_direccion.Text = "Direccion:";
            // 
            // l_edad
            // 
            l_edad.AutoSize = true;
            l_edad.Location = new Point(0, 117);
            l_edad.Name = "l_edad";
            l_edad.Size = new Size(36, 15);
            l_edad.TabIndex = 2;
            l_edad.Text = "Edad:";
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(66, 43);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(100, 23);
            tb_nombre.TabIndex = 4;
            // 
            // tb_direccion
            // 
            tb_direccion.Location = new Point(66, 79);
            tb_direccion.Name = "tb_direccion";
            tb_direccion.Size = new Size(100, 23);
            tb_direccion.TabIndex = 5;
            // 
            // nud_edad
            // 
            nud_edad.Location = new Point(66, 115);
            nud_edad.Name = "nud_edad";
            nud_edad.Size = new Size(120, 23);
            nud_edad.TabIndex = 6;
            // 
            // gb_detallesUsuario
            // 
            gb_detallesUsuario.Controls.Add(nud_edad);
            gb_detallesUsuario.Controls.Add(tb_nombre);
            gb_detallesUsuario.Controls.Add(tb_direccion);
            gb_detallesUsuario.Controls.Add(l_edad);
            gb_detallesUsuario.Controls.Add(l_nombre);
            gb_detallesUsuario.Controls.Add(l_direccion);
            gb_detallesUsuario.Location = new Point(23, 12);
            gb_detallesUsuario.Name = "gb_detallesUsuario";
            gb_detallesUsuario.Size = new Size(231, 187);
            gb_detallesUsuario.TabIndex = 7;
            gb_detallesUsuario.TabStop = false;
            gb_detallesUsuario.Text = "Detalles del usuario";
            // 
            // rb_masculino
            // 
            rb_masculino.AutoSize = true;
            rb_masculino.Checked = true;
            rb_masculino.Location = new Point(6, 35);
            rb_masculino.Name = "rb_masculino";
            rb_masculino.Size = new Size(80, 19);
            rb_masculino.TabIndex = 8;
            rb_masculino.TabStop = true;
            rb_masculino.Text = "Masculino";
            rb_masculino.UseVisualStyleBackColor = true;
            // 
            // rb_femenino
            // 
            rb_femenino.AutoSize = true;
            rb_femenino.Location = new Point(6, 86);
            rb_femenino.Name = "rb_femenino";
            rb_femenino.Size = new Size(78, 19);
            rb_femenino.TabIndex = 9;
            rb_femenino.Text = "Femenino";
            rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_binario
            // 
            rb_binario.AutoSize = true;
            rb_binario.Location = new Point(6, 145);
            rb_binario.Name = "rb_binario";
            rb_binario.Size = new Size(81, 19);
            rb_binario.TabIndex = 10;
            rb_binario.Text = "No binario";
            rb_binario.UseVisualStyleBackColor = true;
            // 
            // gb_genero
            // 
            gb_genero.Controls.Add(rb_masculino);
            gb_genero.Controls.Add(rb_binario);
            gb_genero.Controls.Add(rb_femenino);
            gb_genero.Location = new Point(283, 19);
            gb_genero.Name = "gb_genero";
            gb_genero.Size = new Size(178, 180);
            gb_genero.TabIndex = 11;
            gb_genero.TabStop = false;
            gb_genero.Text = "Genero";
            // 
            // gb_cursos
            // 
            gb_cursos.Controls.Add(cb_javaScript);
            gb_cursos.Controls.Add(cb_cMas);
            gb_cursos.Controls.Add(cb_c);
            gb_cursos.Location = new Point(283, 217);
            gb_cursos.Name = "gb_cursos";
            gb_cursos.Size = new Size(178, 179);
            gb_cursos.TabIndex = 12;
            gb_cursos.TabStop = false;
            gb_cursos.Text = "Cursos";
            // 
            // cb_javaScript
            // 
            cb_javaScript.AutoSize = true;
            cb_javaScript.Location = new Point(6, 141);
            cb_javaScript.Name = "cb_javaScript";
            cb_javaScript.Size = new Size(78, 19);
            cb_javaScript.TabIndex = 2;
            cb_javaScript.Text = "JavaScript";
            cb_javaScript.UseVisualStyleBackColor = true;
            // 
            // cb_cMas
            // 
            cb_cMas.AutoSize = true;
            cb_cMas.Location = new Point(6, 90);
            cb_cMas.Name = "cb_cMas";
            cb_cMas.Size = new Size(53, 19);
            cb_cMas.TabIndex = 1;
            cb_cMas.Text = "C ++";
            cb_cMas.UseVisualStyleBackColor = true;
            // 
            // cb_c
            // 
            cb_c.AutoSize = true;
            cb_c.Location = new Point(6, 42);
            cb_c.Name = "cb_c";
            cb_c.Size = new Size(44, 19);
            cb_c.TabIndex = 0;
            cb_c.Text = "C #";
            cb_c.UseVisualStyleBackColor = true;
            // 
            // lb_pais
            // 
            lb_pais.FormattingEnabled = true;
            lb_pais.ItemHeight = 15;
            lb_pais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lb_pais.Location = new Point(23, 235);
            lb_pais.Name = "lb_pais";
            lb_pais.Size = new Size(231, 229);
            lb_pais.TabIndex = 13;
            // 
            // l_pais
            // 
            l_pais.AutoSize = true;
            l_pais.Location = new Point(23, 217);
            l_pais.Name = "l_pais";
            l_pais.Size = new Size(28, 15);
            l_pais.TabIndex = 14;
            l_pais.Text = "Pais";
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(322, 429);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(100, 35);
            btn_ingresar.TabIndex = 15;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 488);
            Controls.Add(btn_ingresar);
            Controls.Add(l_pais);
            Controls.Add(lb_pais);
            Controls.Add(gb_cursos);
            Controls.Add(gb_genero);
            Controls.Add(gb_detallesUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nud_edad).EndInit();
            gb_detallesUsuario.ResumeLayout(false);
            gb_detallesUsuario.PerformLayout();
            gb_genero.ResumeLayout(false);
            gb_genero.PerformLayout();
            gb_cursos.ResumeLayout(false);
            gb_cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_nombre;
        private Label l_direccion;
        private Label l_edad;
        private TextBox tb_nombre;
        private TextBox tb_direccion;
        private NumericUpDown nud_edad;
        private GroupBox gb_detallesUsuario;
        private RadioButton rb_masculino;
        private RadioButton rb_femenino;
        private RadioButton rb_binario;
        private GroupBox gb_genero;
        private GroupBox gb_cursos;
        private CheckBox cb_javaScript;
        private CheckBox cb_cMas;
        private CheckBox cb_c;
        private ListBox lb_pais;
        private Label l_pais;
        private Button btn_ingresar;
    }
}