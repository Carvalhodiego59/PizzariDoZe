using System.Windows.Forms;

namespace ProjetoDevSistemas2023
{
    partial class clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Painel1 = new Panel();
            maskedTextBoxTELEFONE = new MaskedTextBox();
            EMAILDOCLIENTE = new TextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            TELEFONEDOCLIENTE = new TextBox();
            NomeCliente = new TextBox();
            CPFCliente = new TextBox();
            IDCliente = new TextBox();
            ID = new Label();
            CPF = new Label();
            Nome = new Label();
            TELEFONE = new Label();
            EMAIL = new Label();
            CadastroDoCliente = new Label();
            Cadastrodeendereçodocliente = new Label();
            PAINEL2 = new Panel();
            maskedTextBoxCEP = new MaskedTextBox();
            PAISEND = new TextBox();
            CIDADEEND = new TextBox();
            BAIROEND = new TextBox();
            COMPLEMENTODACASA = new TextBox();
            NUMERODACASA = new TextBox();
            LOGRADOUROEND = new TextBox();
            CEPENDEREÇO = new TextBox();
            ENDEREÇODOID = new TextBox();
            UFEND = new ComboBox();
            IDENDEREÇO = new Label();
            CEP = new Label();
            LOGRADOURO = new Label();
            NUMERO = new Label();
            COMPLEMENTO = new Label();
            BAIRRO = new Label();
            CIDADE = new Label();
            UF = new Label();
            PAÍS = new Label();
            userControl12 = new UserControl1();
            Painel1.SuspendLayout();
            PAINEL2.SuspendLayout();
            SuspendLayout();
            // 
            // Painel1
            // 
            Painel1.BackColor = SystemColors.ControlDark;
            Painel1.Controls.Add(maskedTextBoxTELEFONE);
            Painel1.Controls.Add(EMAILDOCLIENTE);
            Painel1.Controls.Add(maskedTextBoxCPF);
            Painel1.Controls.Add(TELEFONEDOCLIENTE);
            Painel1.Controls.Add(NomeCliente);
            Painel1.Controls.Add(CPFCliente);
            Painel1.Controls.Add(IDCliente);
            Painel1.Controls.Add(ID);
            Painel1.Controls.Add(CPF);
            Painel1.Controls.Add(Nome);
            Painel1.Controls.Add(TELEFONE);
            Painel1.Controls.Add(EMAIL);
            Painel1.Location = new Point(23, 45);
            Painel1.Name = "Painel1";
            Painel1.Size = new Size(796, 136);
            Painel1.TabIndex = 0;
            // 
            // maskedTextBoxTELEFONE
            // 
            maskedTextBoxTELEFONE.Location = new Point(569, 96);
            maskedTextBoxTELEFONE.Mask = "(00) 00000-0000";
            maskedTextBoxTELEFONE.Name = "maskedTextBoxTELEFONE";
            maskedTextBoxTELEFONE.Size = new Size(148, 27);
            maskedTextBoxTELEFONE.TabIndex = 13;
            maskedTextBoxTELEFONE.KeyDown += maskedTextBoxTELEFONE_KeyDown;
            // 
            // EMAILDOCLIENTE
            // 
            EMAILDOCLIENTE.Location = new Point(11, 96);
            EMAILDOCLIENTE.Name = "EMAILDOCLIENTE";
            EMAILDOCLIENTE.Size = new Size(543, 27);
            EMAILDOCLIENTE.TabIndex = 14;
            EMAILDOCLIENTE.KeyDown += EMAILDOCLIENTE_KeyDown;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(155, 32);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(107, 27);
            maskedTextBoxCPF.TabIndex = 2;
            maskedTextBoxCPF.KeyDown += maskedTextBoxCPF_KeyDown;
            // 
            // TELEFONEDOCLIENTE
            // 
            TELEFONEDOCLIENTE.Location = new Point(569, 96);
            TELEFONEDOCLIENTE.Name = "TELEFONEDOCLIENTE";
            TELEFONEDOCLIENTE.Size = new Size(148, 27);
            TELEFONEDOCLIENTE.TabIndex = 35;
            // 
            // NomeCliente
            // 
            NomeCliente.Location = new Point(305, 32);
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Size = new Size(478, 27);
            NomeCliente.TabIndex = 3;
            NomeCliente.KeyDown += NomeCliente_KeyDown;
            // 
            // CPFCliente
            // 
            CPFCliente.Location = new Point(155, 32);
            CPFCliente.Name = "CPFCliente";
            CPFCliente.Size = new Size(107, 27);
            CPFCliente.TabIndex = 7;
            // 
            // IDCliente
            // 
            IDCliente.Location = new Point(11, 32);
            IDCliente.Name = "IDCliente";
            IDCliente.Size = new Size(100, 27);
            IDCliente.TabIndex = 1;
            IDCliente.KeyDown += IDCliente_KeyDown;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(11, 9);
            ID.Name = "ID";
            ID.Size = new Size(27, 20);
            ID.TabIndex = 3;
            ID.Text = "ID:";
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Location = new Point(155, 9);
            CPF.Name = "CPF";
            CPF.Size = new Size(36, 20);
            CPF.TabIndex = 4;
            CPF.Text = "CPF:";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(305, 9);
            Nome.Name = "Nome";
            Nome.Size = new Size(53, 20);
            Nome.TabIndex = 5;
            Nome.Text = "Nome:";
            // 
            // TELEFONE
            // 
            TELEFONE.AutoSize = true;
            TELEFONE.Location = new Point(569, 73);
            TELEFONE.Name = "TELEFONE";
            TELEFONE.Size = new Size(69, 20);
            TELEFONE.TabIndex = 20;
            TELEFONE.Text = "Telefone:";
            // 
            // EMAIL
            // 
            EMAIL.AutoSize = true;
            EMAIL.Location = new Point(11, 73);
            EMAIL.Name = "EMAIL";
            EMAIL.Size = new Size(55, 20);
            EMAIL.TabIndex = 21;
            EMAIL.Text = "E-mail:";
            // 
            // CadastroDoCliente
            // 
            CadastroDoCliente.AutoSize = true;
            CadastroDoCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroDoCliente.Location = new Point(1, 8);
            CadastroDoCliente.Name = "CadastroDoCliente";
            CadastroDoCliente.Size = new Size(236, 35);
            CadastroDoCliente.TabIndex = 2;
            CadastroDoCliente.Text = "Cadastro Do Cliente";
            // 
            // Cadastrodeendereçodocliente
            // 
            Cadastrodeendereçodocliente.AutoSize = true;
            Cadastrodeendereçodocliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Cadastrodeendereçodocliente.Location = new Point(1, 188);
            Cadastrodeendereçodocliente.Name = "Cadastrodeendereçodocliente";
            Cadastrodeendereçodocliente.Size = new Size(407, 35);
            Cadastrodeendereçodocliente.TabIndex = 3;
            Cadastrodeendereçodocliente.Text = "Cadastro De Endereço Dos Clientes";
            // 
            // PAINEL2
            // 
            PAINEL2.BackColor = SystemColors.AppWorkspace;
            PAINEL2.Controls.Add(maskedTextBoxCEP);
            PAINEL2.Controls.Add(PAISEND);
            PAINEL2.Controls.Add(CIDADEEND);
            PAINEL2.Controls.Add(BAIROEND);
            PAINEL2.Controls.Add(COMPLEMENTODACASA);
            PAINEL2.Controls.Add(NUMERODACASA);
            PAINEL2.Controls.Add(LOGRADOUROEND);
            PAINEL2.Controls.Add(CEPENDEREÇO);
            PAINEL2.Controls.Add(ENDEREÇODOID);
            PAINEL2.Controls.Add(UFEND);
            PAINEL2.Controls.Add(IDENDEREÇO);
            PAINEL2.Controls.Add(CEP);
            PAINEL2.Controls.Add(LOGRADOURO);
            PAINEL2.Controls.Add(NUMERO);
            PAINEL2.Controls.Add(COMPLEMENTO);
            PAINEL2.Controls.Add(BAIRRO);
            PAINEL2.Controls.Add(CIDADE);
            PAINEL2.Controls.Add(UF);
            PAINEL2.Controls.Add(PAÍS);
            PAINEL2.Location = new Point(23, 226);
            PAINEL2.Name = "PAINEL2";
            PAINEL2.Size = new Size(878, 150);
            PAINEL2.TabIndex = 4;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(90, 32);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(107, 27);
            maskedTextBoxCEP.TabIndex = 5;
            maskedTextBoxCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCEP.KeyDown += maskedTextBoxCEP_KeyDown;
            maskedTextBoxCEP.Leave += maskedTextBoxCEP_Leave;
            // 
            // PAISEND
            // 
            PAISEND.Location = new Point(569, 102);
            PAISEND.Name = "PAISEND";
            PAISEND.Size = new Size(131, 27);
            PAISEND.TabIndex = 12;
            PAISEND.KeyDown += PAISEND_KeyDown;
            // 
            // CIDADEEND
            // 
            CIDADEEND.Location = new Point(284, 103);
            CIDADEEND.Name = "CIDADEEND";
            CIDADEEND.Size = new Size(140, 27);
            CIDADEEND.TabIndex = 10;
            CIDADEEND.KeyDown += CIDADEEND_KeyDown;
            // 
            // BAIROEND
            // 
            BAIROEND.Location = new Point(90, 103);
            BAIROEND.Name = "BAIROEND";
            BAIROEND.Size = new Size(177, 27);
            BAIROEND.TabIndex = 9;
            BAIROEND.KeyDown += BAIROEND_KeyDown;
            // 
            // COMPLEMENTODACASA
            // 
            COMPLEMENTODACASA.Location = new Point(666, 32);
            COMPLEMENTODACASA.Name = "COMPLEMENTODACASA";
            COMPLEMENTODACASA.Size = new Size(183, 27);
            COMPLEMENTODACASA.TabIndex = 8;
            COMPLEMENTODACASA.KeyDown += COMPLEMENTODACASA_KeyDown;
            // 
            // NUMERODACASA
            // 
            NUMERODACASA.Location = new Point(3, 106);
            NUMERODACASA.Name = "NUMERODACASA";
            NUMERODACASA.Size = new Size(66, 27);
            NUMERODACASA.TabIndex = 7;
            NUMERODACASA.KeyDown += NUMERODACASA_KeyDown;
            // 
            // LOGRADOUROEND
            // 
            LOGRADOUROEND.Location = new Point(213, 32);
            LOGRADOUROEND.Name = "LOGRADOUROEND";
            LOGRADOUROEND.Size = new Size(447, 27);
            LOGRADOUROEND.TabIndex = 6;
            LOGRADOUROEND.KeyDown += LOGRADOUROEND_KeyDown;
            // 
            // CEPENDEREÇO
            // 
            CEPENDEREÇO.Location = new Point(90, 32);
            CEPENDEREÇO.Name = "CEPENDEREÇO";
            CEPENDEREÇO.Size = new Size(107, 27);
            CEPENDEREÇO.TabIndex = 28;
            // 
            // ENDEREÇODOID
            // 
            ENDEREÇODOID.Location = new Point(3, 32);
            ENDEREÇODOID.Name = "ENDEREÇODOID";
            ENDEREÇODOID.Size = new Size(73, 27);
            ENDEREÇODOID.TabIndex = 4;
            ENDEREÇODOID.KeyDown += ENDEREÇODOID_KeyDown;
            // 
            // UFEND
            // 
            UFEND.FormattingEnabled = true;
            UFEND.Items.AddRange(new object[] { "AB - Alberta", "AC - Acre", "AG - Aguascalientes", "AK - Alasca", "AL - Alabama", "AP - Amapá", "AZ - Arizona", "BA - Bahia", "BC - British Columbia", "BS - Baja California Sur", "CA - Califórnia", "CE - Ceará", "CH - Chihuahua", "CI - Chiapas", "CL - Colima", "CM - Campeche", "CO - Colorado", "CO - Coahuila", "CT - Connecticut", "DC - Distrito de Columbia", "DE - Delaware", "DF - Distrito Federal", "DG - Durango", "ES - Espírito Santo", "EM - Estado de México", "FL - Flórida", "GA - Georgia", "GO - Goiás", "GR - Guerrero", "GT - Guanajuato", "HI - Havaí", "HG - Hidalgo", "IA - Iowa", "ID - Idaho", "IL - Illinois", "IN - Indiana", "KS - Kansas", "KY - Kentucky", "LA - Louisiana", "MA - Massachusetts", "MB - Manitoba", "MD - Maryland", "ME - Maine", "MI - Michigan", "MN - Minnesota", "MO - Missouri", "MS - Mississippi", "MT - Montana", "NB - New Brunswick", "NC - Carolina do Norte", "ND - Dakota do Norte", "NE - Nebraska", "NH - New Hampshire", "NJ - Nova Jersey", "NL - Newfoundland and Labrador", "NM - Novo México", "NS - Nova Escócia", "NT - Northwest Territories", "NU - Nunavut", "NV - Nevada", "NY - Nova Iorque", "OA - Oaxaca", "OH - Ohio", "OK - Oklahoma", "ON - Ontario", "OR - Oregon", "PA - Pensilvânia", "PE - Pernambuco", "PR - Paraná", "PU - Puebla", "QC - Quebec", "QE - Querétaro", "QR - Quintana Roo", "RI - Rhode Island", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RO - Rondônia", "RR - Roraima", "RS - Rio Grande do Sul", "SC - Santa Catarina", "SD - Dakota do Sul", "SE - Sergipe", "SI - Sinaloa", "SK - Saskatchewan", "SL - San Luis Potosí", "SO - Sonora", "SP - São Paulo", "TB - Tabasco", "TC - Tocantins", "TL - Tlaxcala", "TN - Tennessee", "TX - Texas", "UT - Utah", "VA - Virginia", "VE - Veracruz", "VT - Vermont", "WA - Washington", "WI - Wisconsin", "WV - West Virginia", "WY - Wyoming" });
            UFEND.Location = new Point(454, 102);
            UFEND.Name = "UFEND";
            UFEND.Size = new Size(100, 28);
            UFEND.TabIndex = 11;
            UFEND.Text = "--Estado--";
            UFEND.KeyDown += UFEND_KeyDown;
            // 
            // IDENDEREÇO
            // 
            IDENDEREÇO.AutoSize = true;
            IDENDEREÇO.Location = new Point(3, 9);
            IDENDEREÇO.Name = "IDENDEREÇO";
            IDENDEREÇO.Size = new Size(27, 20);
            IDENDEREÇO.TabIndex = 11;
            IDENDEREÇO.Text = "ID:";
            // 
            // CEP
            // 
            CEP.AutoSize = true;
            CEP.Location = new Point(90, 9);
            CEP.Name = "CEP";
            CEP.Size = new Size(37, 20);
            CEP.TabIndex = 12;
            CEP.Text = "CEP:";
            // 
            // LOGRADOURO
            // 
            LOGRADOURO.AutoSize = true;
            LOGRADOURO.Location = new Point(213, 9);
            LOGRADOURO.Name = "LOGRADOURO";
            LOGRADOURO.Size = new Size(90, 20);
            LOGRADOURO.TabIndex = 13;
            LOGRADOURO.Text = "Logradouro:";
            // 
            // NUMERO
            // 
            NUMERO.AutoSize = true;
            NUMERO.Location = new Point(3, 83);
            NUMERO.Name = "NUMERO";
            NUMERO.Size = new Size(66, 20);
            NUMERO.TabIndex = 14;
            NUMERO.Text = "Número:";
            // 
            // COMPLEMENTO
            // 
            COMPLEMENTO.AutoSize = true;
            COMPLEMENTO.Location = new Point(666, 9);
            COMPLEMENTO.Name = "COMPLEMENTO";
            COMPLEMENTO.Size = new Size(107, 20);
            COMPLEMENTO.TabIndex = 15;
            COMPLEMENTO.Text = "Complemento:";
            // 
            // BAIRRO
            // 
            BAIRRO.AutoSize = true;
            BAIRRO.Location = new Point(90, 83);
            BAIRRO.Name = "BAIRRO";
            BAIRRO.Size = new Size(52, 20);
            BAIRRO.TabIndex = 16;
            BAIRRO.Text = "Bairro:";
            // 
            // CIDADE
            // 
            CIDADE.AutoSize = true;
            CIDADE.Location = new Point(284, 80);
            CIDADE.Name = "CIDADE";
            CIDADE.Size = new Size(59, 20);
            CIDADE.TabIndex = 17;
            CIDADE.Text = "Cidade:";
            // 
            // UF
            // 
            UF.AutoSize = true;
            UF.Location = new Point(454, 83);
            UF.Name = "UF";
            UF.Size = new Size(29, 20);
            UF.TabIndex = 18;
            UF.Text = "UF:";
            // 
            // PAÍS
            // 
            PAÍS.AutoSize = true;
            PAÍS.Location = new Point(569, 79);
            PAÍS.Name = "PAÍS";
            PAÍS.Size = new Size(37, 20);
            PAÍS.TabIndex = 19;
            PAÍS.Text = "País:";
            // 
            // userControl12
            // 
            userControl12.Location = new Point(236, 401);
            userControl12.Margin = new Padding(3, 7, 3, 7);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(538, 113);
            userControl12.TabIndex = 15;
            userControl12.TabStop = false;
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 516);
            Controls.Add(userControl12);
            Controls.Add(PAINEL2);
            Controls.Add(Cadastrodeendereçodocliente);
            Controls.Add(CadastroDoCliente);
            Controls.Add(Painel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadatro de Clientes";
            Load += Clientes_Load;
            KeyDown += clientes_KeyDown;
            Painel1.ResumeLayout(false);
            Painel1.PerformLayout();
            PAINEL2.ResumeLayout(false);
            PAINEL2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Painel1;
        private Label ID;
        private Label CPF;
        private Label Nome;
        private Label CadastroDoCliente;
        private TextBox NomeCliente;
        private TextBox CPFCliente;
        private TextBox IDCliente;
        private Label Cadastrodeendereçodocliente;
        private Panel PAINEL2;
        private TextBox EMAILDOCLIENTE;
        private TextBox TELEFONEDOCLIENTE;
        private TextBox PAISEND;
        private TextBox CIDADEEND;
        private TextBox BAIROEND;
        private TextBox COMPLEMENTODACASA;
        private TextBox NUMERODACASA;
        private TextBox LOGRADOUROEND;
        private TextBox CEPENDEREÇO;
        private TextBox ENDEREÇODOID;
        private ComboBox UFEND;
        private Label IDENDEREÇO;
        private Label CEP;
        private Label LOGRADOURO;
        private Label NUMERO;
        private Label COMPLEMENTO;
        private Label BAIRRO;
        private Label CIDADE;
        private Label EMAIL;
        private Label UF;
        private Label TELEFONE;
        private Label PAÍS;
        private UserControl1 userControl12;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxTELEFONE;
        private MaskedTextBox maskedTextBoxCEP;
    }
}