<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminContactoResidente.aspx.cs" Inherits="WebCondominio.AdminContactoResidente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
           <br />
	       <ul class="nav menu">
		        <li >&nbsp;<a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span>Home</a></li>
		        <li><a href="AdminHabilitarUser.aspx"><span class="glyphicon glyphicon-briefcase"></span> Control Usuarios</a></li>
		        <li><a href="AdminConsultaResi.aspx"><span class="glyphicon glyphicon-folder-close"></span> Residentes </a></li>
		        <li><a href="AdminGestionMulta.aspx"><span class="glyphicon glyphicon-ban-circle"></span> Gestion de Multas</a></li>
		        <li><a href="AdminConsultaMorosos.aspx"><span class="glyphicon glyphicon-usd"></span> Estados de Pago</a></li>
		        <li><a href="AdminVerificaPagoGasto.aspx"><span class="glyphicon glyphicon-credit-card"></span> Pago Gasto Común</a></li>
                <li class="active"><a href="AdminContactoResidente.aspx"><span class="glyphicon glyphicon-comment"></span> Mensaje Contacto</a></li>
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
				<div class="panel panel-default">
					<div class="panel-heading" aling="center"><center><h2>Consultas Residentes</h2>
                        </center></div>
                        <br />
					<div class="panel-body">
<center>
						<div class="col-md-6">
							
							    <div>
									<center><h4>Consultas Pendientes</h4><br /></center>
                                    
								</div>	
                                
								<div class="form-group">
									<div></div>
                                    <asp:DropDownList ID="ddlPendiente" runat="server" class="form-control"
                                        DataSourceID="SqlDataSource1" DataTextField="ID" 
                                        DataValueField="ID" Width="400px"></asp:DropDownList>
								    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT ID FROM BDCONDOMINIONEW.CONTACTO WHERE SOLUCION = 'Pendiente'">
                                    </asp:SqlDataSource>
								</div>	
                                <div class="form-group">
									<label>Nombre Usuario</label>
									<asp:TextBox ID="lblNombrePendiente" class="form-control" runat="server" Disabled="disabled" Width="400px"></asp:TextBox>
								</div>					
								<div class="form-group">
									<label>Vivienda</label>
									<asp:TextBox ID="lblViviendaPendiente" class="form-control" runat="server" Disabled="disabled" Width="400px"></asp:TextBox>
								</div>
								
								<div class="form-group">
								  <label>Consulta</label>
                                  <asp:TextBox ID="lblConsultaPendiente" class="form-control" runat="server" Disabled="disabled" Columns="50" Rows="5"></asp:TextBox>
                                  
								</div>
                            					
								<div class="form-group">
									<label>Solucion</label>
                                    <asp:TextBox ID="lblSolucion" class="form-control" runat="server" Columns="50" Rows="5"></asp:TextBox>
                                   
								</div>

                                <div class="form-group" aling="center">
                                    
                                    <asp:Button ID="Consultar" runat="server" Text="Consultar" 
                                        class="form-control btn-primary" onclick="Consultar_Click" Width="127px" />
                                        <br />

                                    <asp:Button ID="Responder" runat="server" Text="Responder" 
                                        class="form-control btn-primary" onclick="Responder_Click" Width="127px"/>
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
									<center><h4>Consultas Solucionadas</h4></center>
                                    <br />
								</div>	
								<div class="form-group">
									<div></div>
                                    <asp:DropDownList ID="ddlSolucion" runat="server" class="form-control"
                                        DataSourceID="SqlDataSource2" DataTextField="ID" 
                                        DataValueField="ID" Width="400px"></asp:DropDownList>
								    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT ID FROM BDCONDOMINIONEW.CONTACTO WHERE SOLUCION &lt;&gt;'Pendiente'">
                                    </asp:SqlDataSource>
								</div>	
                                	
                                <div class="form-group">
									<label>Nombre Completo</label>
									<asp:TextBox ID="lblNombreSolucion" class="form-control" runat="server" Disabled="disabled" Width="400px"></asp:TextBox>
								</div>					
								<div class="form-group">
									<label>Vivienda</label>
									<asp:TextBox ID="lblViviendaSolucion" class="form-control" runat="server" Disabled="disabled" Width="400px"></asp:TextBox>
								</div>
								
								<div class="form-group">
								  <label>Consulta</label>
                                  <asp:TextBox ID="lblConsultaSolucion" class="form-control" runat="server" Disabled="disabled" Width="400px" ></asp:TextBox>
                                  
								</div>
                            					
								<div class="form-group">
									<label>Solucion</label>
                                    <asp:TextBox ID="lblSolucionS" class="form-control" runat="server" Disabled="disabled" Width="400px"></asp:TextBox>
								</div>

                                <div class="form-group">
									<label>Nombre Usuario</label>
                                    <asp:TextBox ID="lblNombreUser" class="form-control" runat="server" Disabled="disabled" Width="400px"></asp:TextBox>
								</div>
                                <div class="form-group" aling="center">
                                    <asp:Button ID="ConsultarSolu" runat="server" Text="Consultar" 
                                        class="form-control btn-primary" onclick="ConsultarSolu_Click" />
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

