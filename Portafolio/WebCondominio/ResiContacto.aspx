<%@ Page Title="" Language="C#" MasterPageFile="~/SiteResidente.Master" AutoEventWireup="true" CodeBehind="ResiContacto.aspx.cs" Inherits="WebCondominio.ResiContacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
           <br />
	       <ul class="nav menu">
		        <li><a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span> Home</a></li>
		        <li><a href="ResiConsultaGasto.aspx"><span class="glyphicon glyphicon-briefcase"></span> Gastos Comunes</a></li>
		        <li><a href="ResiIngresaObservacionGasto.aspx"><span class="glyphicon glyphicon-folder-close"></span> Observaciones </a></li>
		        <li><a href="ResiConsultarMultas.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Multas</a></li>
                <li><a href="ResiConsultarMorosidad.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Deudas</a></li>
		        <li><a href="ResiPagarGasto.aspx"><span class="glyphicon glyphicon-usd"></span> Pago Gasto Comun</a></li>
                <li class="parent active"><a href="ResiContacto.aspx"><span class="glyphicon glyphicon-comment"></span> Contacto</a></li>
		        
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
				<div class="panel panel-default">
					<div class="panel-heading" aling="center"><center><h2>Consultas Residente</h2>
                        </center></div>
                        <br />
					<div class="panel-body">
<center>
						<div class="col-md-6">
							
							    <div>
									<center><h4>Enviar Conultas al Administrador</h4><br /></center>
                                    
								</div>	
                                
								
								<div class="form-group">
								  <label>Consulta</label>
                                  <asp:TextBox ID="txtConsulta" class="form-control" Columns="50" Rows="5" 
                                        mode="multiline" runat="server" Height="100px" ></asp:TextBox>
                                  
								</div>

                                <div class="form-group" aling="center">
                                    
                                    <asp:Button ID="Consultar" runat="server" Text="Enviar Consulta" 
                                        class="form-control btn-primary"  Width="127px" 
                                        onclick="Consultar_Click" />
                                        <br />
								</div>
                                <div class="form-group">
                                   <asp:Label ID="lblMensajeUno" runat="server" Text=""></asp:Label>
								    <br />
                                    <br />
                                    <br />
								</div>
							</div>
                            </center>
                            <center>
							<div class="col-md-6">
							    <div class="form-group">
									<center><h4>Consultas Enviadas</h4></center>
                                    <br />
								</div>	
								<div class="form-group">
									<div></div>
                                    <asp:DropDownList ID="ddlSolucion" runat="server" class="form-control" ></asp:DropDownList>
								</div>	
                                	
                                <div class="form-group">
									<label>Nombre Completo</label>
									<asp:TextBox ID="lblNombreSolucion" class="form-control" runat="server" Disabled="disabled" ></asp:TextBox>
								</div>					
								<div class="form-group">
									<label>Vivienda</label>
									<asp:TextBox ID="lblViviendaSolucion" class="form-control" runat="server" Disabled="disabled" ></asp:TextBox>
								</div>
								
								<div class="form-group">
								  <label>Consulta</label>
                                  <asp:TextBox ID="lblConsultaSolucion" class="form-control" runat="server" Disabled="disabled" Columns="50" Rows="5" ></asp:TextBox>
                                  
								</div>
                            					
								<div class="form-group">
									<label>Solucion</label>
                                    <asp:TextBox ID="lblSolucionS" class="form-control" runat="server" Disabled="disabled" Columns="50" Rows="5"></asp:TextBox>
								</div>

                                <div class="form-group">
									<label>Nombre Usuario</label>
                                    <asp:TextBox ID="lblNombreUser" class="form-control" runat="server" Disabled="disabled" ></asp:TextBox>
								</div>
                                <div class="form-group" aling="center">
                                    <asp:Button ID="ConsultarSolu" runat="server" Text="Consultar Estado" 
                                        class="form-control btn-primary" onclick="ConsultarSolu_Click"  />
								</div>
                                <div class="form-group">
                                    <asp:Label ID="lblMnsaje" runat="server" Text=""></asp:Label>
								</div>
							</div>
                            
                            </center>
                          
					</div>
				</div>
			</div><!-- /.col-->
		</div><!-- /.row -->
		
	</div><!--/.main-->

    

    </b></b>

    

</asp:Content>

