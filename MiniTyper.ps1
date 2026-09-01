Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing

# --- UI Setup ---
$form = New-Object System.Windows.Forms.Form
$form.Text = "Mini Typer"
$form.Size = New-Object System.Drawing.Size(350,150)
$form.StartPosition = "CenterScreen"

$label = New-Object System.Windows.Forms.Label
$label.Text = "Text to type:"
$label.Location = New-Object System.Drawing.Point(10,10)
$label.AutoSize = $true
$form.Controls.Add($label)

$textbox = New-Object System.Windows.Forms.TextBox
$textbox.Location = New-Object System.Drawing.Point(10,35)
$textbox.Size = New-Object System.Drawing.Size(310,20)
$form.Controls.Add($textbox)

$button = New-Object System.Windows.Forms.Button
$button.Text = "Submit"
$button.Location = New-Object System.Drawing.Point(10,65)
$form.Controls.Add($button)

# --- Button Click Logic ---
$button.Add_Click({
    $text = $textbox.Text
    if ($text -eq "") { return }

    Start-Sleep -Seconds 5  # Delay so you can switch windows

    [System.Windows.Forms.SendKeys]::SendWait($text)
})

$form.Topmost = $true
$form.ShowDialog()
