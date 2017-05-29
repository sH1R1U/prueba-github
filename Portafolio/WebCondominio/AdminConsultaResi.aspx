<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminConsultaResi.aspx.cs" Inherits="WebCondominio.AdminConsultaResi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
            <br />
	       <ul class="nav menu">
		        <li ><a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span> Home</a></li>
		        <li><a href="AdminHabilitarUser.aspx"><span class="glyphicon glyphicon-briefcase"></span> Control Usuarios</a></li>
		        <li class="active"><a href="AdminConsultaResi.aspx"><span class="glyphicon glyphicon-folder-close"></span> Residentes </a></li>
		        <li><a href="AdminGestionMulta.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Gestion de Multas</a></li>
		        <li><a href="AdminConsultaMorosos.aspx"><span class="glyphicon glyphicon-usd"></span> Estados de Pago</a></li>
		        <li><a href="AdminVerificaPagoGasto.aspx"><span class="glyphicon glyphicon-credit-card"></span> Pago Gasto Común</a></li>
                <li><a href="AdminContactoResidente.aspx"><span class="glyphicon glyphicon-comment"></span> Mensaje Contacto</a></li>
		        <li class="parent ">
			        <a href="#">
				        <span data-toggle="collapse" href="#sub-item-1"><svg class="glyph stroke0´¿'d chevron-down"><use xlink:href="#stroked-chevron-down"></use></svg></span> Areas Comunes
			        </a>
			        <ul class="children collapse" id="sub-item-1">
				        <li>
					        <a href="AdminConsultaAreas.aspx">
						        <span class="glyphicon glyphicon-tree-deciduous"></span> Consulta
					        </a>
				        </li>
				        <li>
					        <a href="AdminReservarAreasComu.aspx">
						        <span class="glyphicon glyphicon-floppy-disk"></span> Reserva
					        </a>
				        </li>
			        </ul>
		        </li>
		        <li role="presentation" class="divider"></li>
	        </ul>
    </div>
	<div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">			
		<div class="row">
			<ol class="breadcrumb">
				<div align="center"><b><li class="active">Bienvenido <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label> </li><b></div>
			</ol>
		</div>
		
		<div class="row">
			<div class="col-lg-12">
				<h1 class="page-header">Dashboard</h1>
			</div>
		</div>
		
		<div class="row">
			<div class="col-xs-12 col-md-6 col-lg-3">
				<div class="panel panel-blue panel-widget ">
					<div class="row no-padding">
						<div class="col-sm-3 col-lg-5 widget-left">
							<svg class="glyph stroked bag"><use xlink:href="#stroked-bag"></use></svg>
						</div>
						<div class="col-sm-9 col-lg-7 widget-right">
							<div class="large">120</div>
							<div class="text-muted">New Orders</div>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-12 col-md-6 col-lg-3">
				<div class="panel panel-orange panel-widget">
					<div class="row no-padding">
						<div class="col-sm-3 col-lg-5 widget-left">
							<svg class="glyph stroked empty-message"><use xlink:href="#stroked-empty-message"></use></svg>
						</div>
						<div class="col-sm-9 col-lg-7 widget-right">
							<div class="large">52</div>
							<div class="text-muted">Comments</div>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-12 col-md-6 col-lg-3">
				<div class="panel panel-teal panel-widget">
					<div class="row no-padding">
						<div class="col-sm-3 col-lg-5 widget-left">
							<svg class="glyph stroked male-user"><use xlink:href="#stroked-male-user"></use></svg>
						</div>
						<div class="col-sm-9 col-lg-7 widget-right">
							<div class="large">24</div>
							<div class="text-muted">New Users</div>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-12 col-md-6 col-lg-3">
				<div class="panel panel-red panel-widget">
					<div class="row no-padding">
						<div class="col-sm-3 col-lg-5 widget-left">
							<svg class="glyph stroked app-window-with-content"><use xlink:href="#stroked-app-window-with-content"></use></svg>
						</div>
						<div class="col-sm-9 col-lg-7 widget-right">
							<div class="large">25.2k</div>
							<div class="text-muted">Page Views</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		
		<div class="row">
			<div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">Site Traffic Overview</div>
					<div class="panel-body">
						<div class="canvas-wrapper">
							<canvas class="main-chart" id="line-chart" height="200" width="600"></canvas>
						</div>
					</div>
				</div>
			</div>
		</div>
		
		<div class="row">
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>New Orders</h4>
						<div class="easypiechart" id="easypiechart-blue" data-percent="92" ><span class="percent">92%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>Comments</h4>
						<div class="easypiechart" id="easypiechart-orange" data-percent="65" ><span class="percent">65%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>New Users</h4>
						<div class="easypiechart" id="easypiechart-teal" data-percent="56" ><span class="percent">56%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>Visitors</h4>
						<div class="easypiechart" id="easypiechart-red" data-percent="27" ><span class="percent">27%</span>
						</div>
					</div>
				</div>
			</div>
		</div>			
	</div>
</b></b>
</asp:Content>

