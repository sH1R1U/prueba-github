<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminHabilitarUser.aspx.cs" Inherits="WebCondominio.AdminHabilitarUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
            <br />
	       <ul class="nav menu">
		        <li><a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span> Home</a></li>
		        <li class="active"><a href="AdminHabilitarUser.aspx"><span class="glyphicon glyphicon-briefcase"></span> Control Usuarios</a></li>
		        <li><a href="AdminConsultaResi.aspx"><span class="glyphicon glyphicon-folder-close"></span> Residentes </a></li>
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
				<div class="panel panel-default">
					<div class="panel-heading">Administradores</div>
					<div class="panel-body">
						<asp:GridView ID="gvusuarioad" runat="server" 
                            CssClass="table table-striped table-bordered table-hover" 
                            AutoGenerateColumns="False" >  
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />  
                                <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" SortExpression="NombreCompleto" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" /> 
                                <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Estado" HeaderText="Estado Cuenta" SortExpression="Estado" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" />  
                                <asp:BoundField DataField="Estado" HeaderText="Habilitada" SortExpression="Estado" ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" /> 
                            </Columns>  
                        </asp:GridView> 
					</div>
                    <br />
                    <div class="row">
                        <div class="col-xs-1"></div>
                        <div class="col-xs-10">

                        <table class="table table-responsive">
                            <tr>
                                <td><strong>Nombre User</strong></td>
                                <td><strong>Estado</strong></td>
                                <td colspan="2"><asp:Label ID="lblMensaje" runat="server" /></td>
                            </tr>
 
                            <tr>
                                <td><asp:DropDownList ID="ddlUserAdmin" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource1" DataTextField="NOMBREUSER" 
                                        DataValueField="NOMBREUSER"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT ID, NOMBRECOMPLETO, RUT, TELEFONO, CORREO, NOMBREUSER, CONTRASENA, IDTIPOUSER, IDESTADO, IDVIVIENDA FROM BDCONDOMINIONEW.USUARIO WHERE (IDTIPOUSER = 1)">
                                    </asp:SqlDataSource>
                                </td>
                                <td><asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource2" DataTextField="ESTADO" DataValueField="ID" ></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT * FROM &quot;ESTADOUSER&quot;"></asp:SqlDataSource>
                                </td>
                                <td><asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                                        CssClass="form-control btn-primary" onclick="btnConsultar_Click" /></td>
                                <td><asp:Button ID="btnEditar" runat="server" Text="Editar" 
                                        CssClass="form-control btn-primary" onclick="btnEditar_Click" /></td>
                            </tr>
                        </table>
                        </div>
                        <div class="col-xs-1"></div>
                    </div>
                        <br />
				</div>
			</div>
            <br />  
            <div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">Conserje</div>
					<div class="panel-body">
						<asp:GridView ID="gvConserje" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" >  
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />  
                                <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" SortExpression="NombreCompleto" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" /> 
                                <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Estado" HeaderText="Estado Cuenta" SortExpression="Estado" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" />  
                                <asp:BoundField DataField="Estado" HeaderText="Habilitada" SortExpression="Estado" ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" /> 
                            </Columns>  
                        </asp:GridView> 
					</div>
                    <div class="row">
                        <div class="col-xs-1"></div>
                        <div class="col-xs-10">
                        <br />
                        <table class="table table-responsive">
                            <tr>
                                <td><strong>Nombre User</strong></td>
                                <td><strong>Estado</strong></td>
                                <td colspan="2"><asp:Label ID="lblMenCon" runat="server" /></td>
                            </tr>
 
                            <tr>
                                <td><asp:DropDownList ID="ddlConserje" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource3" DataTextField="NOMBREUSER" 
                                        DataValueField="NOMBREUSER"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT ID, NOMBRECOMPLETO, RUT, TELEFONO, CORREO, NOMBREUSER, CONTRASENA, IDTIPOUSER, IDESTADO, IDVIVIENDA FROM BDCONDOMINIONEW.USUARIO WHERE (IDTIPOUSER = 2)">
                                    </asp:SqlDataSource>
                                </td>
                                <td><asp:DropDownList ID="ddlConEs" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource4" DataTextField="ESTADO" DataValueField="ID" ></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT * FROM &quot;ESTADOUSER&quot;"></asp:SqlDataSource>
                                </td>
                                <td><asp:Button ID="btnConsCon" runat="server" Text="Consultar" 
                                        CssClass="form-control btn-primary" onclick="btnConsCon_Click" /></td>
                                <td><asp:Button ID="btnEditCon" runat="server" Text="Editar" 
                                        CssClass="form-control btn-primary" onclick="btnEditCon_Click"  /></td>
                            </tr>
                        </table>
                        </div>
                        <div class="col-xs-1"></div>
                    </div>
                        <br />
				</div>
			</div>

            <div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">Directiva</div>
					<div class="panel-body">
						<asp:GridView ID="gvDirectiva" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" >  
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />  
                                <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" SortExpression="NombreCompleto" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" /> 
                                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" /> 
                                <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Estado" HeaderText="Estado Cuenta" SortExpression="Estado" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" /> 
                                <asp:BoundField DataField="Estado" HeaderText="Habilitada" SortExpression="Estado" ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" /> 
                            </Columns>  
                        </asp:GridView> 
					</div>
                    <div class="row">
                        <div class="col-xs-1"></div>
                        <div class="col-xs-10">
                        <br />
                        <table class="table table-responsive">
                            <tr>
                                <td><strong>Nombre User</strong></td>
                                <td><strong>Estado</strong></td>
                                <td colspan="2"><asp:Label ID="lblMenDirec" runat="server" /></td>
                            </tr>
 
                            <tr>
                                <td><asp:DropDownList ID="ddlConDi" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource5" DataTextField="NOMBREUSER" 
                                        DataValueField="NOMBREUSER"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT ID, NOMBRECOMPLETO, RUT, TELEFONO, CORREO, NOMBREUSER, CONTRASENA, IDTIPOUSER, IDESTADO, IDVIVIENDA FROM BDCONDOMINIONEW.USUARIO WHERE (IDTIPOUSER = 3)">
                                    </asp:SqlDataSource>
                                </td>
                                <td><asp:DropDownList ID="ddlEditDi" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource6" DataTextField="ESTADO" DataValueField="ID" ></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT * FROM &quot;ESTADOUSER&quot;"></asp:SqlDataSource>
                                </td>
                                <td><asp:Button ID="btnConsulDi" runat="server" Text="Consultar" 
                                        CssClass="form-control btn-primary" onclick="btnConsulDi_Click"  /></td>
                                <td><asp:Button ID="btnEditDi" runat="server" Text="Editar" 
                                        CssClass="form-control btn-primary" onclick="btnEditDi_Click" /></td>
                            </tr>
                        </table>
                        </div>
                        <div class="col-xs-1"></div>
                    </div>
                        <br />
				</div>
			</div>

            <div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">Residente</div>
					<div class="panel-body">
						<asp:GridView ID="gvResidente" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" >  
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />  
                                <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" SortExpression="NombreCompleto" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="NVivienda" HeaderText="N° Vivienda" SortExpression="NVivienda" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />  
                                <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login"  ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                <asp:BoundField DataField="Estado" HeaderText="Estado Cuenta" SortExpression="Estado" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />
                                <asp:BoundField DataField="NombreUser" HeaderText="Nombre User" SortExpression="NombreUser"  ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" />  
                                <asp:BoundField DataField="NVivienda" HeaderText="N° Vivienda" SortExpression="NVivienda" HeaderStyle-CssClass="hidden-lg" ItemStyle-CssClass="hidden-lg" />   
                                <asp:BoundField DataField="Estado" HeaderText="Habilitada" SortExpression="Estado" ItemStyle-CssClass="hidden-lg" HeaderStyle-CssClass="hidden-lg" /> 
                            </Columns>  
                        </asp:GridView> 
					</div>
                    <div class="row">
                        <div class="col-xs-1"></div>
                        <div class="col-xs-10">
                        <br />
                        <table class="table table-responsive">
                            <tr>
                                <td><strong>Nombre User</strong></td>
                                <td><strong>Estado</strong></td>
                                <td colspan="2"><asp:Label ID="lblMenResi" runat="server" /></td>
                            </tr>
 
                            <tr>
                                <td><asp:DropDownList ID="ddlResiUser" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource7" DataTextField="NOMBREUSER" 
                                        DataValueField="NOMBREUSER"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT ID, NOMBRECOMPLETO, RUT, TELEFONO, CORREO, NOMBREUSER, CONTRASENA, IDTIPOUSER, IDESTADO, IDVIVIENDA FROM BDCONDOMINIONEW.USUARIO WHERE (IDTIPOUSER = 4)">
                                    </asp:SqlDataSource>
                                </td>
                                <td><asp:DropDownList ID="ddlEstadoResi" runat="server" CssClass="form-control" 
                                        DataSourceID="SqlDataSource8" DataTextField="ESTADO" DataValueField="ID" ></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource8" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                                        SelectCommand="SELECT * FROM &quot;ESTADOUSER&quot;"></asp:SqlDataSource>
                                </td>
                                <td><asp:Button ID="btnConsResi" runat="server" Text="Consultar" 
                                        CssClass="form-control btn-primary" onclick="btnConsResi_Click"  /></td>
                                <td><asp:Button ID="btnEditResi" runat="server" Text="Editar" 
                                        CssClass="form-control btn-primary" onclick="btnEditResi_Click"  /></td>
                            </tr>
                        </table>
                        </div>
                        <div class="col-xs-1"></div>
                    </div>
                        <br />
				</div>
			</div>
		</div>
		</div>
        </b></b>
</asp:Content>
