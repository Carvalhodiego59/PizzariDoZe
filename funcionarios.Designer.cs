using ProjetoDevSistemas2023;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetoDevSistemas2023
{
    partial class funcionarios
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
            CADASTROFUNC = new Label();
            IDFUNC = new Label();
            CPFFUNC = new Label();
            MATRICULAFUNC = new Label();
            NOMEFUNC = new Label();
            CMFUNC = new Label();
            VALIDADE = new Label();
            OBSERVAÇAOFUNC = new Label();
            SENHA = new Label();
            RESENHA = new Label();
            REGENDDOFUN = new Label();
            IDFUNCEND = new Label();
            CEPFUNCEND = new Label();
            LOGFUNCEND = new Label();
            NUMEROFUNCEND = new Label();
            COMPLEMENTOFUNCEND = new Label();
            BAIRROFUNCEND = new Label();
            CIDADEFUNCEND = new Label();
            UFENDFUN = new Label();
            PAÍSFUNCEND = new Label();
            TELEFONEFUNCEND = new Label();
            EMAILFUNCEND = new Label();
            panel1 = new Panel();
            dateTimePickerValidade = new DateTimePicker();
            maskedTextBoxcarteiramotorista = new MaskedTextBox();
            maskedTextBoxtelefone = new MaskedTextBox();
            EMAILFUNENDRES = new TextBox();
            maskedTextBoxcpf = new MaskedTextBox();
            COMPFUNENDRES = new TextBox();
            TELEFONEENDRESFUN = new TextBox();
            NFUNENRES = new TextBox();
            RESENHARES = new TextBox();
            SENHARES = new TextBox();
            CMFUNCRES = new TextBox();
            OBSRES = new TextBox();
            NOMEFUNCRES = new TextBox();
            MAFUNCRES = new TextBox();
            CPFFUNCRES = new TextBox();
            IDFUNCRES = new TextBox();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButtonGrupoAtendente = new RadioButton();
            radioButtonGrupoAdmin = new RadioButton();
            radioButtonEntregador = new RadioButton();
            maskedTextBoxcep = new MaskedTextBox();
            PENDRESFUN = new TextBox();
            CIDFUNENDRES = new TextBox();
            BAIRROFUNENDRES = new TextBox();
            LOGFUNCENDRES = new TextBox();
            CEPFUNCENDRES = new TextBox();
            IDFUNCRESEND = new TextBox();
            UFFUNENDRES = new ComboBox();
            userControl12 = new UserControl1();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // CADASTROFUNC
            // 
            CADASTROFUNC.AutoSize = true;
            CADASTROFUNC.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CADASTROFUNC.Location = new Point(442, 9);
            CADASTROFUNC.Name = "CADASTROFUNC";
            CADASTROFUNC.Size = new Size(262, 35);
            CADASTROFUNC.TabIndex = 0;
            CADASTROFUNC.Text = "Cadastro Funcionários";
            CADASTROFUNC.Click += CADASTROFUNC_Click;
            // 
            // IDFUNC
            // 
            IDFUNC.AutoSize = true;
            IDFUNC.Location = new Point(3, 15);
            IDFUNC.Name = "IDFUNC";
            IDFUNC.Size = new Size(27, 20);
            IDFUNC.TabIndex = 1;
            IDFUNC.Text = "ID:";
            // 
            // CPFFUNC
            // 
            CPFFUNC.AutoSize = true;
            CPFFUNC.Location = new Point(90, 15);
            CPFFUNC.Name = "CPFFUNC";
            CPFFUNC.Size = new Size(36, 20);
            CPFFUNC.TabIndex = 2;
            CPFFUNC.Text = "CPF:";
            // 
            // MATRICULAFUNC
            // 
            MATRICULAFUNC.AutoSize = true;
            MATRICULAFUNC.Location = new Point(239, 15);
            MATRICULAFUNC.Name = "MATRICULAFUNC";
            MATRICULAFUNC.Size = new Size(74, 20);
            MATRICULAFUNC.TabIndex = 3;
            MATRICULAFUNC.Text = "Matrícula:";
            // 
            // NOMEFUNC
            // 
            NOMEFUNC.AutoSize = true;
            NOMEFUNC.Location = new Point(393, 15);
            NOMEFUNC.Name = "NOMEFUNC";
            NOMEFUNC.Size = new Size(53, 20);
            NOMEFUNC.TabIndex = 4;
            NOMEFUNC.Text = "Nome:";
            // 
            // CMFUNC
            // 
            CMFUNC.AutoSize = true;
            CMFUNC.Location = new Point(3, 96);
            CMFUNC.Name = "CMFUNC";
            CMFUNC.Size = new Size(155, 20);
            CMFUNC.TabIndex = 5;
            CMFUNC.Text = "Carteira De Motorista:";
            // 
            // VALIDADE
            // 
            VALIDADE.AutoSize = true;
            VALIDADE.Location = new Point(175, 99);
            VALIDADE.Name = "VALIDADE";
            VALIDADE.Size = new Size(70, 20);
            VALIDADE.TabIndex = 6;
            VALIDADE.Text = "Validade:";
            // 
            // OBSERVAÇAOFUNC
            // 
            OBSERVAÇAOFUNC.AutoSize = true;
            OBSERVAÇAOFUNC.Location = new Point(901, 15);
            OBSERVAÇAOFUNC.Name = "OBSERVAÇAOFUNC";
            OBSERVAÇAOFUNC.Size = new Size(90, 20);
            OBSERVAÇAOFUNC.TabIndex = 7;
            OBSERVAÇAOFUNC.Text = "Observação:";
            // 
            // SENHA
            // 
            SENHA.AutoSize = true;
            SENHA.Location = new Point(406, 99);
            SENHA.Name = "SENHA";
            SENHA.Size = new Size(52, 20);
            SENHA.TabIndex = 8;
            SENHA.Text = "Senha:";
            // 
            // RESENHA
            // 
            RESENHA.AutoSize = true;
            RESENHA.Location = new Point(556, 99);
            RESENHA.Name = "RESENHA";
            RESENHA.Size = new Size(75, 20);
            RESENHA.TabIndex = 9;
            RESENHA.Text = "Re-Senha:";
            // 
            // REGENDDOFUN
            // 
            REGENDDOFUN.AutoSize = true;
            REGENDDOFUN.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            REGENDDOFUN.Location = new Point(393, 262);
            REGENDDOFUN.Name = "REGENDDOFUN";
            REGENDDOFUN.Size = new Size(432, 35);
            REGENDDOFUN.TabIndex = 10;
            REGENDDOFUN.Text = "Registro De Endereço Do Funcionário";
            // 
            // IDFUNCEND
            // 
            IDFUNCEND.AutoSize = true;
            IDFUNCEND.Location = new Point(3, 9);
            IDFUNCEND.Name = "IDFUNCEND";
            IDFUNCEND.Size = new Size(27, 20);
            IDFUNCEND.TabIndex = 11;
            IDFUNCEND.Text = "ID:";
            // 
            // CEPFUNCEND
            // 
            CEPFUNCEND.AutoSize = true;
            CEPFUNCEND.Location = new Point(90, 9);
            CEPFUNCEND.Name = "CEPFUNCEND";
            CEPFUNCEND.Size = new Size(37, 20);
            CEPFUNCEND.TabIndex = 12;
            CEPFUNCEND.Text = "CEP:";
            // 
            // LOGFUNCEND
            // 
            LOGFUNCEND.AutoSize = true;
            LOGFUNCEND.Location = new Point(213, 9);
            LOGFUNCEND.Name = "LOGFUNCEND";
            LOGFUNCEND.Size = new Size(90, 20);
            LOGFUNCEND.TabIndex = 13;
            LOGFUNCEND.Text = "Logradouro:";
            // 
            // NUMEROFUNCEND
            // 
            NUMEROFUNCEND.AutoSize = true;
            NUMEROFUNCEND.Location = new Point(577, 151);
            NUMEROFUNCEND.Name = "NUMEROFUNCEND";
            NUMEROFUNCEND.Size = new Size(66, 20);
            NUMEROFUNCEND.TabIndex = 14;
            NUMEROFUNCEND.Text = "Número:";
            // 
            // COMPLEMENTOFUNCEND
            // 
            COMPLEMENTOFUNCEND.AutoSize = true;
            COMPLEMENTOFUNCEND.Location = new Point(649, 152);
            COMPLEMENTOFUNCEND.Name = "COMPLEMENTOFUNCEND";
            COMPLEMENTOFUNCEND.Size = new Size(107, 20);
            COMPLEMENTOFUNCEND.TabIndex = 15;
            COMPLEMENTOFUNCEND.Text = "Complemento:";
            // 
            // BAIRROFUNCEND
            // 
            BAIRROFUNCEND.AutoSize = true;
            BAIRROFUNCEND.Location = new Point(449, 83);
            BAIRROFUNCEND.Name = "BAIRROFUNCEND";
            BAIRROFUNCEND.Size = new Size(52, 20);
            BAIRROFUNCEND.TabIndex = 16;
            BAIRROFUNCEND.Text = "Bairro:";
            // 
            // CIDADEFUNCEND
            // 
            CIDADEFUNCEND.AutoSize = true;
            CIDADEFUNCEND.Location = new Point(3, 83);
            CIDADEFUNCEND.Name = "CIDADEFUNCEND";
            CIDADEFUNCEND.Size = new Size(59, 20);
            CIDADEFUNCEND.TabIndex = 17;
            CIDADEFUNCEND.Text = "Cidade:";
            // 
            // UFENDFUN
            // 
            UFENDFUN.AutoSize = true;
            UFENDFUN.Location = new Point(159, 83);
            UFENDFUN.Name = "UFENDFUN";
            UFENDFUN.Size = new Size(29, 20);
            UFENDFUN.TabIndex = 18;
            UFENDFUN.Text = "UF:";
            // 
            // PAÍSFUNCEND
            // 
            PAÍSFUNCEND.AutoSize = true;
            PAÍSFUNCEND.Location = new Point(283, 83);
            PAÍSFUNCEND.Name = "PAÍSFUNCEND";
            PAÍSFUNCEND.Size = new Size(37, 20);
            PAÍSFUNCEND.TabIndex = 19;
            PAÍSFUNCEND.Text = "País:";
            // 
            // TELEFONEFUNCEND
            // 
            TELEFONEFUNCEND.AutoSize = true;
            TELEFONEFUNCEND.Location = new Point(729, 99);
            TELEFONEFUNCEND.Name = "TELEFONEFUNCEND";
            TELEFONEFUNCEND.Size = new Size(69, 20);
            TELEFONEFUNCEND.TabIndex = 20;
            TELEFONEFUNCEND.Text = "Telefone:";
            // 
            // EMAILFUNCEND
            // 
            EMAILFUNCEND.AutoSize = true;
            EMAILFUNCEND.Location = new Point(0, 151);
            EMAILFUNCEND.Name = "EMAILFUNCEND";
            EMAILFUNCEND.Size = new Size(55, 20);
            EMAILFUNCEND.TabIndex = 21;
            EMAILFUNCEND.Text = "E-mail:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(dateTimePickerValidade);
            panel1.Controls.Add(maskedTextBoxcarteiramotorista);
            panel1.Controls.Add(maskedTextBoxtelefone);
            panel1.Controls.Add(EMAILFUNENDRES);
            panel1.Controls.Add(maskedTextBoxcpf);
            panel1.Controls.Add(COMPFUNENDRES);
            panel1.Controls.Add(TELEFONEENDRESFUN);
            panel1.Controls.Add(NFUNENRES);
            panel1.Controls.Add(RESENHARES);
            panel1.Controls.Add(SENHARES);
            panel1.Controls.Add(CMFUNCRES);
            panel1.Controls.Add(OBSRES);
            panel1.Controls.Add(NOMEFUNCRES);
            panel1.Controls.Add(MAFUNCRES);
            panel1.Controls.Add(COMPLEMENTOFUNCEND);
            panel1.Controls.Add(CPFFUNCRES);
            panel1.Controls.Add(IDFUNCRES);
            panel1.Controls.Add(NUMEROFUNCEND);
            panel1.Controls.Add(RESENHA);
            panel1.Controls.Add(IDFUNC);
            panel1.Controls.Add(CPFFUNC);
            panel1.Controls.Add(MATRICULAFUNC);
            panel1.Controls.Add(NOMEFUNC);
            panel1.Controls.Add(CMFUNC);
            panel1.Controls.Add(EMAILFUNCEND);
            panel1.Controls.Add(VALIDADE);
            panel1.Controls.Add(OBSERVAÇAOFUNC);
            panel1.Controls.Add(SENHA);
            panel1.Controls.Add(TELEFONEFUNCEND);
            panel1.Location = new Point(27, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 206);
            panel1.TabIndex = 0;
            // 
            // dateTimePickerValidade
            // 
            dateTimePickerValidade.Location = new Point(175, 119);
            dateTimePickerValidade.Name = "dateTimePickerValidade";
            dateTimePickerValidade.Size = new Size(225, 27);
            dateTimePickerValidade.TabIndex = 37;
            // 
            // maskedTextBoxcarteiramotorista
            // 
            maskedTextBoxcarteiramotorista.Location = new Point(3, 121);
            maskedTextBoxcarteiramotorista.Name = "maskedTextBoxcarteiramotorista";
            maskedTextBoxcarteiramotorista.Size = new Size(73, 27);
            maskedTextBoxcarteiramotorista.TabIndex = 36;
            // 
            // maskedTextBoxtelefone
            // 
            maskedTextBoxtelefone.Location = new Point(729, 121);
            maskedTextBoxtelefone.Mask = "(00) 00000-0000";
            maskedTextBoxtelefone.Name = "maskedTextBoxtelefone";
            maskedTextBoxtelefone.Size = new Size(148, 27);
            maskedTextBoxtelefone.TabIndex = 19;
            maskedTextBoxtelefone.KeyDown += maskedTextBoxtelefone_KeyDown;
            // 
            // EMAILFUNENDRES
            // 
            EMAILFUNENDRES.Location = new Point(6, 171);
            EMAILFUNENDRES.Name = "EMAILFUNENDRES";
            EMAILFUNENDRES.Size = new Size(559, 27);
            EMAILFUNENDRES.TabIndex = 20;
            EMAILFUNENDRES.KeyDown += EMAILFUNENDRES_KeyDown;
            // 
            // maskedTextBoxcpf
            // 
            maskedTextBoxcpf.Location = new Point(90, 37);
            maskedTextBoxcpf.Mask = "000.000.000-00";
            maskedTextBoxcpf.Name = "maskedTextBoxcpf";
            maskedTextBoxcpf.Size = new Size(125, 27);
            maskedTextBoxcpf.TabIndex = 2;
            maskedTextBoxcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxcpf.KeyDown += maskedTextBoxcpf_KeyDown;
            // 
            // COMPFUNENDRES
            // 
            COMPFUNENDRES.Location = new Point(649, 171);
            COMPFUNENDRES.Name = "COMPFUNENDRES";
            COMPFUNENDRES.Size = new Size(228, 27);
            COMPFUNENDRES.TabIndex = 14;
            COMPFUNENDRES.KeyDown += COMPFUNENDRES_KeyDown;
            // 
            // TELEFONEENDRESFUN
            // 
            TELEFONEENDRESFUN.Location = new Point(729, 122);
            TELEFONEENDRESFUN.Name = "TELEFONEENDRESFUN";
            TELEFONEENDRESFUN.Size = new Size(148, 27);
            TELEFONEENDRESFUN.TabIndex = 35;
            // 
            // NFUNENRES
            // 
            NFUNENRES.Location = new Point(577, 171);
            NFUNENRES.Name = "NFUNENRES";
            NFUNENRES.Size = new Size(66, 27);
            NFUNENRES.TabIndex = 13;
            NFUNENRES.KeyDown += NFUNENRES_KeyDown;
            // 
            // RESENHARES
            // 
            RESENHARES.Location = new Point(556, 122);
            RESENHARES.Name = "RESENHARES";
            RESENHARES.Size = new Size(148, 27);
            RESENHARES.TabIndex = 8;
            RESENHARES.KeyDown += RESENHARES_KeyDown;
            // 
            // SENHARES
            // 
            SENHARES.Location = new Point(406, 122);
            SENHARES.Name = "SENHARES";
            SENHARES.Size = new Size(131, 27);
            SENHARES.TabIndex = 7;
            SENHARES.KeyDown += SENHARES_KeyDown;
            // 
            // CMFUNCRES
            // 
            CMFUNCRES.Location = new Point(3, 121);
            CMFUNCRES.Name = "CMFUNCRES";
            CMFUNCRES.Size = new Size(70, 27);
            CMFUNCRES.TabIndex = 5;
            CMFUNCRES.KeyDown += CMFUNCRES_KeyDown;
            // 
            // OBSRES
            // 
            OBSRES.Location = new Point(901, 37);
            OBSRES.Multiline = true;
            OBSRES.Name = "OBSRES";
            OBSRES.Size = new Size(285, 129);
            OBSRES.TabIndex = 9;
            OBSRES.KeyDown += OBSRES_KeyDown;
            // 
            // NOMEFUNCRES
            // 
            NOMEFUNCRES.Location = new Point(393, 37);
            NOMEFUNCRES.Name = "NOMEFUNCRES";
            NOMEFUNCRES.Size = new Size(498, 27);
            NOMEFUNCRES.TabIndex = 4;
            NOMEFUNCRES.KeyDown += NOMEFUNCRES_KeyDown;
            // 
            // MAFUNCRES
            // 
            MAFUNCRES.Location = new Point(239, 37);
            MAFUNCRES.Name = "MAFUNCRES";
            MAFUNCRES.Size = new Size(125, 27);
            MAFUNCRES.TabIndex = 3;
            MAFUNCRES.KeyDown += MAFUNCRES_KeyDown;
            // 
            // CPFFUNCRES
            // 
            CPFFUNCRES.Location = new Point(90, 37);
            CPFFUNCRES.Name = "CPFFUNCRES";
            CPFFUNCRES.Size = new Size(124, 27);
            CPFFUNCRES.TabIndex = 11;
            // 
            // IDFUNCRES
            // 
            IDFUNCRES.Location = new Point(3, 37);
            IDFUNCRES.Name = "IDFUNCRES";
            IDFUNCRES.Size = new Size(73, 27);
            IDFUNCRES.TabIndex = 1;
            IDFUNCRES.KeyDown += IDFUNCRES_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(maskedTextBoxcep);
            panel3.Controls.Add(PENDRESFUN);
            panel3.Controls.Add(CIDFUNENDRES);
            panel3.Controls.Add(BAIRROFUNENDRES);
            panel3.Controls.Add(LOGFUNCENDRES);
            panel3.Controls.Add(CEPFUNCENDRES);
            panel3.Controls.Add(IDFUNCRESEND);
            panel3.Controls.Add(UFFUNENDRES);
            panel3.Controls.Add(IDFUNCEND);
            panel3.Controls.Add(CEPFUNCEND);
            panel3.Controls.Add(LOGFUNCEND);
            panel3.Controls.Add(BAIRROFUNCEND);
            panel3.Controls.Add(CIDADEFUNCEND);
            panel3.Controls.Add(UFENDFUN);
            panel3.Controls.Add(PAÍSFUNCEND);
            panel3.Location = new Point(146, 300);
            panel3.Name = "panel3";
            panel3.Size = new Size(997, 168);
            panel3.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioButtonGrupoAtendente);
            flowLayoutPanel1.Controls.Add(radioButtonGrupoAdmin);
            flowLayoutPanel1.Controls.Add(radioButtonEntregador);
            flowLayoutPanel1.Location = new Point(732, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 29;
            // 
            // radioButtonGrupoAtendente
            // 
            radioButtonGrupoAtendente.AutoSize = true;
            radioButtonGrupoAtendente.Location = new Point(3, 3);
            radioButtonGrupoAtendente.Name = "radioButtonGrupoAtendente";
            radioButtonGrupoAtendente.Size = new Size(99, 24);
            radioButtonGrupoAtendente.TabIndex = 1;
            radioButtonGrupoAtendente.TabStop = true;
            radioButtonGrupoAtendente.Text = "Atendente";
            radioButtonGrupoAtendente.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrupoAdmin
            // 
            radioButtonGrupoAdmin.AutoSize = true;
            radioButtonGrupoAdmin.Location = new Point(108, 3);
            radioButtonGrupoAdmin.Name = "radioButtonGrupoAdmin";
            radioButtonGrupoAdmin.Size = new Size(125, 24);
            radioButtonGrupoAdmin.TabIndex = 0;
            radioButtonGrupoAdmin.TabStop = true;
            radioButtonGrupoAdmin.Text = "Administrador";
            radioButtonGrupoAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntregador
            // 
            radioButtonEntregador.AutoSize = true;
            radioButtonEntregador.Location = new Point(3, 33);
            radioButtonEntregador.Name = "radioButtonEntregador";
            radioButtonEntregador.Size = new Size(104, 24);
            radioButtonEntregador.TabIndex = 2;
            radioButtonEntregador.TabStop = true;
            radioButtonEntregador.Text = "Entregador";
            radioButtonEntregador.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxcep
            // 
            maskedTextBoxcep.Location = new Point(90, 32);
            maskedTextBoxcep.Mask = "00000-000";
            maskedTextBoxcep.Name = "maskedTextBoxcep";
            maskedTextBoxcep.Size = new Size(107, 27);
            maskedTextBoxcep.TabIndex = 11;
            maskedTextBoxcep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxcep.KeyDown += maskedTextBoxcep_KeyDown;
            maskedTextBoxcep.Leave += maskedTextBoxcep_Leave;
            // 
            // PENDRESFUN
            // 
            PENDRESFUN.Location = new Point(283, 105);
            PENDRESFUN.Name = "PENDRESFUN";
            PENDRESFUN.Size = new Size(131, 27);
            PENDRESFUN.TabIndex = 18;
            PENDRESFUN.KeyDown += PENDRESFUN_KeyDown;
            // 
            // CIDFUNENDRES
            // 
            CIDFUNENDRES.Location = new Point(3, 105);
            CIDFUNENDRES.Name = "CIDFUNENDRES";
            CIDFUNENDRES.Size = new Size(140, 27);
            CIDFUNENDRES.TabIndex = 16;
            CIDFUNENDRES.KeyDown += CIDFUNENDRES_KeyDown;
            // 
            // BAIRROFUNENDRES
            // 
            BAIRROFUNENDRES.Location = new Point(449, 104);
            BAIRROFUNENDRES.Name = "BAIRROFUNENDRES";
            BAIRROFUNENDRES.Size = new Size(177, 27);
            BAIRROFUNENDRES.TabIndex = 15;
            BAIRROFUNENDRES.KeyDown += BAIRROFUNENDRES_KeyDown;
            // 
            // LOGFUNCENDRES
            // 
            LOGFUNCENDRES.Location = new Point(213, 32);
            LOGFUNCENDRES.Name = "LOGFUNCENDRES";
            LOGFUNCENDRES.Size = new Size(447, 27);
            LOGFUNCENDRES.TabIndex = 12;
            LOGFUNCENDRES.KeyDown += LOGFUNCENDRES_KeyDown;
            // 
            // CEPFUNCENDRES
            // 
            CEPFUNCENDRES.Location = new Point(90, 32);
            CEPFUNCENDRES.Name = "CEPFUNCENDRES";
            CEPFUNCENDRES.Size = new Size(107, 27);
            CEPFUNCENDRES.TabIndex = 28;
            // 
            // IDFUNCRESEND
            // 
            IDFUNCRESEND.Location = new Point(3, 32);
            IDFUNCRESEND.Name = "IDFUNCRESEND";
            IDFUNCRESEND.Size = new Size(73, 27);
            IDFUNCRESEND.TabIndex = 10;
            IDFUNCRESEND.KeyDown += IDFUNCRESEND_KeyDown;
            // 
            // UFFUNENDRES
            // 
            UFFUNENDRES.FormattingEnabled = true;
            UFFUNENDRES.Items.AddRange(new object[] { "AB - Alberta", "AC - Acre", "AG - Aguascalientes", "AK - Alasca", "AL - Alabama", "AP - Amapá", "AZ - Arizona", "BA - Bahia", "BC - British Columbia", "BS - Baja California Sur", "CA - Califórnia", "CE - Ceará", "CH - Chihuahua", "CI - Chiapas", "CL - Colima", "CM - Campeche", "CO - Colorado", "CO - Coahuila", "CT - Connecticut", "DC - Distrito de Columbia", "DE - Delaware", "DF - Distrito Federal", "DG - Durango", "ES - Espírito Santo", "EM - Estado de México", "FL - Flórida", "GA - Georgia", "GO - Goiás", "GR - Guerrero", "GT - Guanajuato", "HI - Havaí", "HG - Hidalgo", "IA - Iowa", "ID - Idaho", "IL - Illinois", "IN - Indiana", "KS - Kansas", "KY - Kentucky", "LA - Louisiana", "MA - Massachusetts", "MB - Manitoba", "MD - Maryland", "ME - Maine", "MI - Michigan", "MN - Minnesota", "MO - Missouri", "MS - Mississippi", "MT - Montana", "NB - New Brunswick", "NC - Carolina do Norte", "ND - Dakota do Norte", "NE - Nebraska", "NH - New Hampshire", "NJ - Nova Jersey", "NL - Newfoundland and Labrador", "NM - Novo México", "NS - Nova Escócia", "NT - Northwest Territories", "NU - Nunavut", "NV - Nevada", "NY - Nova Iorque", "OA - Oaxaca", "OH - Ohio", "OK - Oklahoma", "ON - Ontario", "OR - Oregon", "PA - Pensilvânia", "PE - Pernambuco", "PR - Paraná", "PU - Puebla", "QC - Quebec", "QE - Querétaro", "QR - Quintana Roo", "RI - Rhode Island", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RO - Rondônia", "RR - Roraima", "RS - Rio Grande do Sul", "SC - Santa Catarina", "SD - Dakota do Sul", "SE - Sergipe", "SI - Sinaloa", "SK - Saskatchewan", "SL - San Luis Potosí", "SO - Sonora", "SP - São Paulo", "TB - Tabasco", "TC - Tocantins", "TL - Tlaxcala", "TN - Tennessee", "TX - Texas", "UT - Utah", "VA - Virginia", "VE - Veracruz", "VT - Vermont", "WA - Washington", "WI - Wisconsin", "WV - West Virginia", "WY - Wyoming" });
            UFFUNENDRES.Location = new Point(162, 104);
            UFFUNENDRES.Name = "UFFUNENDRES";
            UFFUNENDRES.Size = new Size(100, 28);
            UFFUNENDRES.TabIndex = 17;
            UFFUNENDRES.Text = "--Estado--";
            UFFUNENDRES.KeyDown += UFFUNENDRES_KeyDown;
            // 
            // userControl12
            // 
            userControl12.Location = new Point(321, 470);
            userControl12.Margin = new Padding(3, 7, 3, 7);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(583, 116);
            userControl12.TabIndex = 21;
            userControl12.TabStop = false;
            // 
            // funcionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 570);
            Controls.Add(userControl12);
            Controls.Add(panel3);
            Controls.Add(REGENDDOFUN);
            Controls.Add(panel1);
            Controls.Add(CADASTROFUNC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "funcionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "funcionarios";
            Load += funcionarios_Load;
            KeyDown += funcionarios_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CADASTROFUNC;
        private Label IDFUNC;
        private Label CPFFUNC;
        private Label MATRICULAFUNC;
        private Label NOMEFUNC;
        private Label CMFUNC;
        private Label VALIDADE;
        private Label OBSERVAÇAOFUNC;
        private Label SENHA;
        private Label RESENHA;
        private Label REGENDDOFUN;
        private Label IDFUNCEND;
        private Label CEPFUNCEND;
        private Label LOGFUNCEND;
        private Label NUMEROFUNCEND;
        private Label COMPLEMENTOFUNCEND;
        private Label BAIRROFUNCEND;
        private Label CIDADEFUNCEND;
        private Label UFENDFUN;
        private Label PAÍSFUNCEND;
        private Label TELEFONEFUNCEND;
        private Label EMAILFUNCEND;
        private Panel panel1;
        private Panel panel3;
        private TextBox RESENHARES;
        private TextBox SENHARES;
        private TextBox CMFUNCRES;
        private TextBox OBSRES;
        private TextBox NOMEFUNCRES;
        private TextBox MAFUNCRES;
        private TextBox CPFFUNCRES;
        private TextBox IDFUNCRES;
        private TextBox EMAILFUNENDRES;
        private TextBox TELEFONEENDRESFUN;
        private TextBox PENDRESFUN;
        private TextBox CIDFUNENDRES;
        private TextBox BAIRROFUNENDRES;
        private TextBox COMPFUNENDRES;
        private TextBox NFUNENRES;
        private TextBox LOGFUNCENDRES;
        private TextBox CEPFUNCENDRES;
        private TextBox IDFUNCRESEND;
        private ComboBox UFFUNENDRES;
        private UserControl1 userControl12;
        private MaskedTextBox maskedTextBoxcpf;
        private MaskedTextBox maskedTextBoxcep;
        private MaskedTextBox maskedTextBoxtelefone;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButtonGrupoAtendente;
        private RadioButton radioButtonGrupoAdmin;
        private RadioButton radioButtonEntregador;
        private MaskedTextBox maskedTextBoxcarteiramotorista;
        private DateTimePicker dateTimePickerValidade;
    }
}