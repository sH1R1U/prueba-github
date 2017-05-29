<%@ Page Title="" Language="C#" MasterPageFile="~/SiteConseje.Master" AutoEventWireup="true" CodeBehind="ConserConsuInforResidente.aspx.cs" Inherits="WebCondominio.ConserConsuInforResidente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
           <br />
	       <ul class="nav menu">
		        <li><a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span> Home</a></li>
		        <li><a href="ConserConsultaPagoGastos.aspx"><span class="glyphicon glyphicon-briefcase"></span> Gastos Comunes</a></li>
		        <li><a href="ConserConsultaMultas.aspx"><span class="glyphicon glyphicon-folder-close"></span> Multas </a></li>
		        <li><a href="ConserConsultaPagoMultas.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Pago Multas</a></li>
                <li><a href="ConserConsultaAreas.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Areas Comunes</a></li>
		        <li><a href="ConserConsultaMorosos.aspx"><span class="glyphicon glyphicon-usd"></span> Morosos</a></li>
                <li class="parent active"><a href="ConserConsuInforResidente.aspx"><span class="glyphicon glyphicon-comment"></span> Residentes</a></li>
                <li> <a href="ConserReservarAreas.aspx"><span class="glyphicon glyphicon-floppy-disk"></span> Reserva Areas</a></li>
		        <li role="presentation" class="divider"></li>
	        </ul>
    </div>
	<div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">			
		<div class="row">
			<ol class="breadcrumb">
				<div align="center"><b><li class="active">Bienvenido <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label> </li><b></div>
			</ol>
		</div>
</asp:Content>
