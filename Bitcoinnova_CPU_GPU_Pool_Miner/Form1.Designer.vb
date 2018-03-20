<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.wallet_address = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pool = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mining = New System.Windows.Forms.Button()
        Me.lbl_threads = New System.Windows.Forms.Label()
        Me.threads = New System.Windows.Forms.TextBox()
        Me.custom_pool = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.TextBox()
        Me.cpuorgpu = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_gpubrand = New System.Windows.Forms.Label()
        Me.gpubrand = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.RichTextBox()
        Me.check = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.Tab_controller = New System.Windows.Forms.TabControl()
        Me.tab_miner = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.new_miner = New System.Windows.Forms.Button()
        Me.donate = New System.Windows.Forms.Button()
        Me.tab_as = New System.Windows.Forms.TabPage()
        Me.update_lbl = New System.Windows.Forms.Label()
        Me.hyperthread = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xmr_notice = New System.Windows.Forms.Label()
        Me.xmr_stak_perf_box = New System.Windows.Forms.ComboBox()
        Me.stak_nvidia_perf = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.miner_type = New System.Windows.Forms.ComboBox()
        Me.open_miners = New System.Windows.Forms.ListBox()
        Me.load_config = New System.Windows.Forms.Button()
        Me.save_config = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.save_config_dialog = New System.Windows.Forms.SaveFileDialog()
        Me.open_config_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.Tab_controller.SuspendLayout()
        Me.tab_miner.SuspendLayout()
        Me.tab_as.SuspendLayout()
        Me.SuspendLayout()
        '
        'wallet_address
        '
        Me.wallet_address.Location = New System.Drawing.Point(4, 21)
        Me.wallet_address.Margin = New System.Windows.Forms.Padding(2)
        Me.wallet_address.Name = "wallet_address"
        Me.wallet_address.Size = New System.Drawing.Size(578, 20)
        Me.wallet_address.TabIndex = 0
        Me.wallet_address.Text = "EAsX15ieXY1NAk9Yu3NoVBfBqUgsFPsv47Ff4W1t491vHiD8fyGHD7nR7gVk1FrcbP2d2mJfBt3M45Ngb" &
    "V6ZRcSdHixcSPH"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(445, 41)
        Me.clear.Margin = New System.Windows.Forms.Padding(2)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(137, 25)
        Me.clear.TabIndex = 1
        Me.clear.Text = "Clear Wallet Address field"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bitcoin Nova Wallet Address:"
        '
        'pool
        '
        Me.pool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pool.FormattingEnabled = True
        Me.pool.Items.AddRange(New Object() {"pool.bitcoinn.biz (Official pool)", "bitcoinn.multipool.es", "bitcoinn.criptominando.eu", "btn.dreampool.info", "superblockchain.con-ip.com", "btn.gonspool.com", "custom"})
        Me.pool.Location = New System.Drawing.Point(36, 71)
        Me.pool.Margin = New System.Windows.Forms.Padding(2)
        Me.pool.Name = "pool"
        Me.pool.Size = New System.Drawing.Size(546, 21)
        Me.pool.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pool:"
        '
        'mining
        '
        Me.mining.ForeColor = System.Drawing.Color.DodgerBlue
        Me.mining.Location = New System.Drawing.Point(4, 168)
        Me.mining.Margin = New System.Windows.Forms.Padding(2)
        Me.mining.Name = "mining"
        Me.mining.Size = New System.Drawing.Size(578, 39)
        Me.mining.TabIndex = 6
        Me.mining.Text = "Start Mining"
        Me.mining.UseVisualStyleBackColor = True
        '
        'lbl_threads
        '
        Me.lbl_threads.AutoSize = True
        Me.lbl_threads.Location = New System.Drawing.Point(4, 135)
        Me.lbl_threads.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_threads.Name = "lbl_threads"
        Me.lbl_threads.Size = New System.Drawing.Size(75, 13)
        Me.lbl_threads.TabIndex = 7
        Me.lbl_threads.Text = "Thread Count:"
        '
        'threads
        '
        Me.threads.Location = New System.Drawing.Point(79, 132)
        Me.threads.Margin = New System.Windows.Forms.Padding(2)
        Me.threads.Name = "threads"
        Me.threads.Size = New System.Drawing.Size(19, 20)
        Me.threads.TabIndex = 8
        Me.threads.Text = "4"
        '
        'custom_pool
        '
        Me.custom_pool.Enabled = False
        Me.custom_pool.Location = New System.Drawing.Point(152, 102)
        Me.custom_pool.Margin = New System.Windows.Forms.Padding(2)
        Me.custom_pool.Name = "custom_pool"
        Me.custom_pool.Size = New System.Drawing.Size(431, 20)
        Me.custom_pool.TabIndex = 9
        Me.custom_pool.Text = "Select custom in pool list to use your own"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 104)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Custom Pool:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 135)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Port:"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(146, 132)
        Me.port.Margin = New System.Windows.Forms.Padding(2)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(40, 20)
        Me.port.TabIndex = 12
        Me.port.Text = "11133"
        '
        'cpuorgpu
        '
        Me.cpuorgpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cpuorgpu.FormattingEnabled = True
        Me.cpuorgpu.Items.AddRange(New Object() {"CPU", "GPU"})
        Me.cpuorgpu.Location = New System.Drawing.Point(4, 44)
        Me.cpuorgpu.Margin = New System.Windows.Forms.Padding(2)
        Me.cpuorgpu.Name = "cpuorgpu"
        Me.cpuorgpu.Size = New System.Drawing.Size(104, 21)
        Me.cpuorgpu.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "stratum+tcp://"
        '
        'lbl_gpubrand
        '
        Me.lbl_gpubrand.AutoSize = True
        Me.lbl_gpubrand.Location = New System.Drawing.Point(113, 46)
        Me.lbl_gpubrand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_gpubrand.Name = "lbl_gpubrand"
        Me.lbl_gpubrand.Size = New System.Drawing.Size(64, 13)
        Me.lbl_gpubrand.TabIndex = 20
        Me.lbl_gpubrand.Text = "GPU Brand:"
        '
        'gpubrand
        '
        Me.gpubrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gpubrand.FormattingEnabled = True
        Me.gpubrand.Items.AddRange(New Object() {"Nvidia", "AMD"})
        Me.gpubrand.Location = New System.Drawing.Point(181, 44)
        Me.gpubrand.Margin = New System.Windows.Forms.Padding(2)
        Me.gpubrand.Name = "gpubrand"
        Me.gpubrand.Size = New System.Drawing.Size(104, 21)
        Me.gpubrand.TabIndex = 21
        '
        'status
        '
        Me.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status.Location = New System.Drawing.Point(4, 212)
        Me.status.Margin = New System.Windows.Forms.Padding(2)
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Size = New System.Drawing.Size(578, 208)
        Me.status.TabIndex = 0
        Me.status.Text = resources.GetString("status.Text")
        '
        'check
        '
        Me.check.Location = New System.Drawing.Point(361, 124)
        Me.check.Margin = New System.Windows.Forms.Padding(2)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(122, 39)
        Me.check.TabIndex = 26
        Me.check.Text = "Check earned BTN"
        Me.check.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.Location = New System.Drawing.Point(236, 124)
        Me.help.Margin = New System.Windows.Forms.Padding(2)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(121, 39)
        Me.help.TabIndex = 27
        Me.help.Text = "Help/Autotune"
        Me.help.UseVisualStyleBackColor = True
        '
        'Tab_controller
        '
        Me.Tab_controller.Controls.Add(Me.tab_miner)
        Me.Tab_controller.Controls.Add(Me.tab_as)
        Me.Tab_controller.Location = New System.Drawing.Point(0, 118)
        Me.Tab_controller.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_controller.Name = "Tab_controller"
        Me.Tab_controller.SelectedIndex = 0
        Me.Tab_controller.Size = New System.Drawing.Size(592, 451)
        Me.Tab_controller.TabIndex = 28
        '
        'tab_miner
        '
        Me.tab_miner.Controls.Add(Me.Label11)
        Me.tab_miner.Controls.Add(Me.new_miner)
        Me.tab_miner.Controls.Add(Me.donate)
        Me.tab_miner.Controls.Add(Me.Label1)
        Me.tab_miner.Controls.Add(Me.help)
        Me.tab_miner.Controls.Add(Me.wallet_address)
        Me.tab_miner.Controls.Add(Me.check)
        Me.tab_miner.Controls.Add(Me.clear)
        Me.tab_miner.Controls.Add(Me.status)
        Me.tab_miner.Controls.Add(Me.pool)
        Me.tab_miner.Controls.Add(Me.Label2)
        Me.tab_miner.Controls.Add(Me.gpubrand)
        Me.tab_miner.Controls.Add(Me.mining)
        Me.tab_miner.Controls.Add(Me.lbl_gpubrand)
        Me.tab_miner.Controls.Add(Me.lbl_threads)
        Me.tab_miner.Controls.Add(Me.threads)
        Me.tab_miner.Controls.Add(Me.custom_pool)
        Me.tab_miner.Controls.Add(Me.Label9)
        Me.tab_miner.Controls.Add(Me.Label5)
        Me.tab_miner.Controls.Add(Me.Label6)
        Me.tab_miner.Controls.Add(Me.cpuorgpu)
        Me.tab_miner.Controls.Add(Me.port)
        Me.tab_miner.Location = New System.Drawing.Point(4, 22)
        Me.tab_miner.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_miner.Name = "tab_miner"
        Me.tab_miner.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_miner.Size = New System.Drawing.Size(584, 425)
        Me.tab_miner.TabIndex = 0
        Me.tab_miner.Text = "Miner"
        Me.tab_miner.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(146, 2)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Make sure to use your own wallet address!"
        '
        'new_miner
        '
        Me.new_miner.ForeColor = System.Drawing.Color.Red
        Me.new_miner.Location = New System.Drawing.Point(409, 168)
        Me.new_miner.Margin = New System.Windows.Forms.Padding(2)
        Me.new_miner.Name = "new_miner"
        Me.new_miner.Size = New System.Drawing.Size(172, 39)
        Me.new_miner.TabIndex = 32
        Me.new_miner.Text = "Stop Mining"
        Me.new_miner.UseVisualStyleBackColor = True
        Me.new_miner.Visible = False
        '
        'donate
        '
        Me.donate.BackColor = System.Drawing.Color.Transparent
        Me.donate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donate.ForeColor = System.Drawing.Color.LimeGreen
        Me.donate.Location = New System.Drawing.Point(487, 124)
        Me.donate.Margin = New System.Windows.Forms.Padding(2)
        Me.donate.Name = "donate"
        Me.donate.Size = New System.Drawing.Size(94, 39)
        Me.donate.TabIndex = 31
        Me.donate.Text = "Donate"
        Me.donate.UseVisualStyleBackColor = False
        '
        'tab_as
        '
        Me.tab_as.Controls.Add(Me.update_lbl)
        Me.tab_as.Controls.Add(Me.hyperthread)
        Me.tab_as.Controls.Add(Me.Label3)
        Me.tab_as.Controls.Add(Me.Label8)
        Me.tab_as.Controls.Add(Me.Label10)
        Me.tab_as.Controls.Add(Me.xmr_notice)
        Me.tab_as.Controls.Add(Me.xmr_stak_perf_box)
        Me.tab_as.Controls.Add(Me.stak_nvidia_perf)
        Me.tab_as.Controls.Add(Me.Label4)
        Me.tab_as.Controls.Add(Me.miner_type)
        Me.tab_as.Controls.Add(Me.open_miners)
        Me.tab_as.Controls.Add(Me.load_config)
        Me.tab_as.Controls.Add(Me.save_config)
        Me.tab_as.Location = New System.Drawing.Point(4, 22)
        Me.tab_as.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_as.Name = "tab_as"
        Me.tab_as.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_as.Size = New System.Drawing.Size(584, 425)
        Me.tab_as.TabIndex = 1
        Me.tab_as.Text = "Advanced Settings"
        Me.tab_as.UseVisualStyleBackColor = True
        '
        'update_lbl
        '
        Me.update_lbl.AutoSize = True
        Me.update_lbl.Location = New System.Drawing.Point(146, 20)
        Me.update_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.update_lbl.Name = "update_lbl"
        Me.update_lbl.Size = New System.Drawing.Size(100, 13)
        Me.update_lbl.TabIndex = 44
        Me.update_lbl.Text = "UPDATE_STATUS"
        '
        'hyperthread
        '
        Me.hyperthread.AutoSize = True
        Me.hyperthread.Location = New System.Drawing.Point(8, 115)
        Me.hyperthread.Margin = New System.Windows.Forms.Padding(2)
        Me.hyperthread.Name = "hyperthread"
        Me.hyperthread.Size = New System.Drawing.Size(121, 17)
        Me.hyperthread.TabIndex = 43
        Me.hyperthread.Text = "Hyperthreaded CPU"
        Me.hyperthread.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(600, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Save and Load Configuration: __________________________________________________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 193)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(611, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Multiple Miners: ______________________________________________________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 93)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(605, 15)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Mining Configuration: _________________________________________________________"
        '
        'xmr_notice
        '
        Me.xmr_notice.AutoSize = True
        Me.xmr_notice.Location = New System.Drawing.Point(6, 173)
        Me.xmr_notice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.xmr_notice.Name = "xmr_notice"
        Me.xmr_notice.Size = New System.Drawing.Size(422, 13)
        Me.xmr_notice.TabIndex = 39
        Me.xmr_notice.Text = "Note: If you try and use high performance mode and it crashes, switch back to sta" &
    "ndard."
        '
        'xmr_stak_perf_box
        '
        Me.xmr_stak_perf_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xmr_stak_perf_box.FormattingEnabled = True
        Me.xmr_stak_perf_box.Items.AddRange(New Object() {"Standard", "High", "Extreme"})
        Me.xmr_stak_perf_box.Location = New System.Drawing.Point(146, 150)
        Me.xmr_stak_perf_box.Margin = New System.Windows.Forms.Padding(2)
        Me.xmr_stak_perf_box.Name = "xmr_stak_perf_box"
        Me.xmr_stak_perf_box.Size = New System.Drawing.Size(104, 21)
        Me.xmr_stak_perf_box.TabIndex = 38
        Me.xmr_stak_perf_box.Visible = False
        '
        'stak_nvidia_perf
        '
        Me.stak_nvidia_perf.AutoSize = True
        Me.stak_nvidia_perf.Location = New System.Drawing.Point(6, 151)
        Me.stak_nvidia_perf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stak_nvidia_perf.Name = "stak_nvidia_perf"
        Me.stak_nvidia_perf.Size = New System.Drawing.Size(133, 13)
        Me.stak_nvidia_perf.TabIndex = 37
        Me.stak_nvidia_perf.Text = "xmr-stak-nvidia perf. mode:"
        Me.stak_nvidia_perf.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Miner backend (Change only if the default doesn't work):"
        '
        'miner_type
        '
        Me.miner_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.miner_type.FormattingEnabled = True
        Me.miner_type.Location = New System.Drawing.Point(283, 131)
        Me.miner_type.Margin = New System.Windows.Forms.Padding(2)
        Me.miner_type.Name = "miner_type"
        Me.miner_type.Size = New System.Drawing.Size(104, 21)
        Me.miner_type.TabIndex = 35
        '
        'open_miners
        '
        Me.open_miners.FormattingEnabled = True
        Me.open_miners.Items.AddRange(New Object() {"Miner No. |Address:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|Backend:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|Pool:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.open_miners.Location = New System.Drawing.Point(4, 212)
        Me.open_miners.Margin = New System.Windows.Forms.Padding(2)
        Me.open_miners.Name = "open_miners"
        Me.open_miners.Size = New System.Drawing.Size(579, 212)
        Me.open_miners.TabIndex = 33
        '
        'load_config
        '
        Me.load_config.Location = New System.Drawing.Point(7, 58)
        Me.load_config.Margin = New System.Windows.Forms.Padding(2)
        Me.load_config.Name = "load_config"
        Me.load_config.Size = New System.Drawing.Size(134, 33)
        Me.load_config.TabIndex = 32
        Me.load_config.Text = "Load Configuration"
        Me.load_config.UseVisualStyleBackColor = True
        '
        'save_config
        '
        Me.save_config.Location = New System.Drawing.Point(7, 20)
        Me.save_config.Margin = New System.Windows.Forms.Padding(2)
        Me.save_config.Name = "save_config"
        Me.save_config.Size = New System.Drawing.Size(134, 33)
        Me.save_config.TabIndex = 31
        Me.save_config.Text = "Save Configuration"
        Me.save_config.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(95, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Label7"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = Global.Bitcoinnova_CPU_GPU_Pool_Miner.My.Resources.Resources.logo_trans
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 114)
        Me.Panel1.TabIndex = 29
        '
        'open_config_dialog
        '
        Me.open_config_dialog.FileName = "File name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tab_controller)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Bicoin Nova CPU GPU Pool Miner "
        Me.Tab_controller.ResumeLayout(False)
        Me.tab_miner.ResumeLayout(False)
        Me.tab_miner.PerformLayout()
        Me.tab_as.ResumeLayout(False)
        Me.tab_as.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wallet_address As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pool As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mining As Button
    Friend WithEvents lbl_threads As Label
    Friend WithEvents threads As TextBox
    Friend WithEvents custom_pool As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents port As TextBox
    Friend WithEvents cpuorgpu As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_gpubrand As Label
    Friend WithEvents gpubrand As ComboBox
    Friend WithEvents status As RichTextBox
    Friend WithEvents check As Button
    Friend WithEvents help As Button
    Friend WithEvents Tab_controller As TabControl
    Friend WithEvents tab_miner As TabPage
    Friend WithEvents tab_as As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents donate As Button
    Friend WithEvents open_miners As ListBox
    Friend WithEvents load_config As Button
    Friend WithEvents save_config As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents miner_type As ComboBox
    Friend WithEvents stak_nvidia_perf As Label
    Friend WithEvents xmr_stak_perf_box As ComboBox
    Friend WithEvents xmr_notice As Label
    Friend WithEvents save_config_dialog As SaveFileDialog
    Friend WithEvents open_config_dialog As OpenFileDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents hyperthread As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents new_miner As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents update_lbl As Label
End Class
