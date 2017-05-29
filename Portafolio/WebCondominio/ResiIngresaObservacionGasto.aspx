<%@ Page Title="" Language="C#" MasterPageFile="~/SiteResidente.Master" AutoEventWireup="true" CodeBehind="ResiIngresaObservacionGasto.aspx.cs" Inherits="WebCondominio.ResiIngresaObservacionGasto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
           <br />
	       <ul class="nav menu">
		        <li><a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span> Home</a></li>
		        <li><a href="ResiConsultaGasto.aspx"><span class="glyphicon glyphicon-briefcase"></span> Gastos Comunes</a></li>
		        <li class="parent active"><a href="ResiIngresaObservacionGasto.aspx"><span class="glyphicon glyphicon-folder-close"></span> Observaciones </a></li>
		        <li><a href="ResiConsultarMultas.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Multas</a></li>
                <li><a href="ResiConsultarMorosidad.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Deudas</a></li>
		        <li><a href="ResiPagarGasto.aspx"><span class="glyphicon glyphicon-usd"></span> Pago Gasto Comun</a></li>
                <li><a href="ResiContacto.aspx"><span class="glyphicon glyphicon-comment"></span> Contacto</a></li>
                 <li><a href="ResiConsultaAreas.aspx"><span class="glyphicon glyphicon-tree-deciduous"></span> Areas Disponibles</a></li>
                <li> <a href="ResiReservaAreasComunes.aspx"><span class="glyphicon glyphicon-floppy-disk"></span> Reserva Areas</a></li>
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
				<center><h1 class="page-header">Ingresar Observaciones</h1></center>
			</div>
		</div>
		
		<div class="row">
			<div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">
                    <div></div>
                    <div class="row">
                    <div class="col-xs-1"></div>
                    <div class="col-xs-2">
                    <asp:DropDownList ID="ddlMes" runat="server" class="form-control" 
                        AutoPostBack="True" onselectedindexchanged="ddlMes_SelectedIndexChanged" 
                        >
                        <asp:ListItem Value="01-01-2017">Enero</asp:ListItem>
                        <asp:ListItem Value="02-02-2017">Febrero</asp:ListItem>
                        <asp:ListItem Value="03-03-2017">Marzo</asp:ListItem>
                        <asp:ListItem Value="04-04-2017">Abril</asp:ListItem>
                        <asp:ListItem Value="05-05-2017">Mayo</asp:ListItem>
                        <asp:ListItem Value="06-06-2017">Junio</asp:ListItem>
                        <asp:ListItem Value="07-07-2017">Julio</asp:ListItem>
                        <asp:ListItem Value="08-08-2017">Agosto</asp:ListItem>
                        <asp:ListItem Value="09-09-2017">Septiembre</asp:ListItem>
                        <asp:ListItem Value="10-10-2017">Octubre</asp:ListItem>
                        <asp:ListItem Value="11-11-2017">Noviembre</asp:ListItem>
                        <asp:ListItem Value="12-12-2017">Diciembre</asp:ListItem>
                    </asp:DropDownList></div>
                    <div class="col-xs-2">
                    <asp:DropDownList ID="ddlAnio" runat="server" class="form-control" AutoPostBack="true"
                            onselectedindexchanged="ddlAnio_SelectedIndexChanged">
                    <asp:ListItem Value="01-01-2015">2015</asp:ListItem>
                    <asp:ListItem Value="01-01-2016">2016</asp:ListItem>
                    <asp:ListItem Value="01-01-2017">2017</asp:ListItem>
                    </asp:DropDownList></div>
                    <div class="col-xs-4"><asp:DropDownList ID="ddlGasto" runat="server" class="form-control" >
        </asp:DropDownList></div>
                    <div class="col-xs-2">
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                            class="form-control btn-primary" onclick="btnConsultar_Click"
                             /></div>
                            <div class="col-xs-1"></div></div></div>
					<div class="panel-body">
                  

						<div class="canvas-wrapper">
                             
							<b>
                             
							<asp:GridView ID="gvusuarioad" runat="server" 
                            CssClass="table table-striped table-bordered table-hover"
                            AutoGenerateColumns="False">  
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />  
                                <asp:BoundField DataField="FechaGasto" HeaderText="FechaGasto" 
                                    SortExpression="FechaGasto" />  
                                <asp:BoundField DataField="NombreGastoComun" HeaderText="NombreGastoComun" 
                                    SortExpression="NombreGastoComun"  
                                     >  
                                </asp:BoundField>
                                <asp:BoundField DataField="ValorGasto" HeaderText="ValorGasto" 
                                    SortExpression="ValorGasto"/>
                            </Columns>  
                        </asp:GridView>
    </b>
                        <br />
                             <center><asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label></center>
						</div>
					</div>
                    <div class="panel-body">
						<div class="canvas-wrapper">
							<b>
							<asp:GridView ID="gvMultas" runat="server" 
                            CssClass="table table-striped table-bordered table-hover"
                            AutoGenerateColumns="False" >  
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />  
                                <asp:BoundField DataField="FechaMulta" HeaderText="FechaMulta" 
                                    SortExpression="FechaMulta" />  
                                <asp:BoundField DataField="DetalleMulta" HeaderText="DetalleMulta" 
                                    SortExpression="DetalleMulta"  >  
                                </asp:BoundField>
                                <asp:BoundField DataField="ValorMulta" HeaderText="ValorMulta" 
                                    SortExpression="ValorMulta"/>
                            </Columns>  
                        </asp:GridView>
                         </b>
                             <center><asp:Label ID="LblMensajeMulta" runat="server" Text=""></asp:Label></center>    
                        </div>
					</div>
                    <div class="panel-body">
						<div class="canvas-wrapper">
                             <center><asp:TextBox ID="txtObservacion" PlaceHolder="Ingrese una Observacion" CssClass="form-control" Visible="false" runat="server"></asp:TextBox></center>
                             <br />
                              <center><asp:Button
                                      ID="btnActualizarobservacion" CssClass="btn-primary form-control" 
                                      visible="false" runat="server" Text="Enviar Observacion" 
                                      onclick="btnActualizarobservacion_Click" /></center>
                                      <br />
                                      <center><asp:Label ID="lblMensa" runat="server" Text=""></asp:Label></center> 
						</div>
					</div>
				</div>
			</div>
		</div>
        </div>
</asp:Content>