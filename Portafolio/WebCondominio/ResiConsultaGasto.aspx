﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteResidente.Master" AutoEventWireup="true" CodeBehind="ResiConsultaGasto.aspx.cs" Inherits="WebCondominio.ResiConsultaGasto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
           <br />
	       <ul class="nav menu">
		        <li><a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span> Home</a></li>
		        <li class="parent active"><a href="ResiConsultaGasto.aspx"><span class="glyphicon glyphicon-briefcase"></span> Gastos Comunes</a></li>
		        <li><a href="ResiIngresaObservacionGasto.aspx"><span class="glyphicon glyphicon-folder-close"></span> Observaciones </a></li>
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
				<center><h1 class="page-header">Gastos Comunes</h1></center>
			</div>
		</div>
		
		<div class="row">
			<div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">
                    <div></div>
                    <div class="row">
                    <div class="col-xs-1"></div>
                    <div class="col-xs-3">
                    <asp:DropDownList ID="ddlMes" runat="server" class="form-control">
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
                    <div class="col-xs-3">
                    <asp:DropDownList ID="ddlAnio" runat="server" class="form-control">
                    <asp:ListItem Value="01-01-2015">2015</asp:ListItem>
                    <asp:ListItem Value="01-01-2016">2016</asp:ListItem>
                    <asp:ListItem Value="01-01-2017">2017</asp:ListItem>
                    </asp:DropDownList></div>
                    <div class="col-xs-3">
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" class="form-control btn-primary"
                            onclick="btnConsultar_Click" /></div>
                            <div class="col-xs-2"></div></div></div>
					<div class="panel-body">
                  

						<div class="canvas-wrapper">
                             
							<b>
                             
							<asp:GridView ID="gvusuarioad" runat="server" 
                            CssClass="table table-striped table-bordered table-hover"
                            AutoGenerateColumns="False">  
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />  
                                <asp:BoundField DataField="vivienda" HeaderText="Vivienda" 
                                    SortExpression="vivienda" />  
                                <asp:BoundField DataField="usuario" HeaderText="Usuario" 
                                    SortExpression="usuario" ItemStyle-CssClass="hidden-xs" 
                                    HeaderStyle-CssClass="hidden-xs" >  
<HeaderStyle CssClass="hidden-xs"></HeaderStyle>

<ItemStyle CssClass="hidden-xs"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField DataField="FechaGasto" HeaderText="Mes Gasto Comun" 
                                    SortExpression="FechaGasto" DataFormatString="{0:Y}"/>
                                <asp:BoundField DataField="ValorTotal" HeaderText="Valor Total" 
                                    SortExpression="ValorTotal"  ItemStyle-CssClass="hidden-xs" 
                                    HeaderStyle-CssClass="hidden-xs" > 
<HeaderStyle CssClass="hidden-xs"></HeaderStyle>

<ItemStyle CssClass="hidden-xs"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField DataField="EstadoPago" HeaderText="Estado Pago" 
                                    SortExpression="EstadoPago"  />  
                                <asp:BoundField DataField="FechaPago" HeaderText="Fecha Pago" 
                                    SortExpression="FechaPago" DataFormatString="{0:d}"  ItemStyle-CssClass="hidden-xs" 
                                    HeaderStyle-CssClass="hidden-xs" >
<HeaderStyle CssClass="hidden-xs"></HeaderStyle>

<ItemStyle CssClass="hidden-xs"></ItemStyle>
                                </asp:BoundField>
                            </Columns>  
                        </asp:GridView>
    </b>
                        <br />
                             <center><asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label></center>
						</div>
					</div>
				</div>
			</div>
		</div>
        </div>
    </b></b>
</asp:Content>