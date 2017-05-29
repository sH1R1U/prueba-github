<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebCondominio.Inicio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Forms</title>

<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/styles.css" rel="stylesheet">


      
      
      <br />
</head>

<body>
	<form id="form1" runat="server">
	<div class="row">
		<div class="col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
			<div class="login-panel panel panel-default">
				<div class="panel-heading text-center" >Iniciar Sesion</div>
				<div class="panel-body">
						<fieldset>
							<div class="form-group">
								<asp:TextBox ID="txtNombre" class="form-control" runat="server" placeHolder="Nombre Usuario"></asp:TextBox>
							</div>
							<div class="form-group">
								<asp:TextBox ID="txtContrasena" class="form-control" type="password" runat="server" placeHolder="Contraseña"></asp:TextBox>
							</div>
							<div class="checkbox">
									<center><asp:Label ID="lblMensaje" runat="server" Text="" Style="color:Red"></asp:Label></center>
							</div>
							<center><asp:Button ID="Iniciar" class="form-control btn-primary" runat="server" Text="Iniciar Sesion" onclick="Iniciar_Click" /></center>
						</fieldset>
				</div>
			</div>
		</div><!-- /.col-->
	</div><!-- /.row -->	
	</form>
		

	<script type="text/javascript"  src="js/jquery-1.11.1.min.js"></script>
	<script type="text/javascript"  src="js/bootstrap.min.js"></script>
	<script type="text/javascript"  src="js/bootstrap-datepicker.js"></script>
	
</body>

</html>
