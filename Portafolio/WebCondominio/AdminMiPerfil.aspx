<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminMiPerfil.aspx.cs" Inherits="WebCondominio.AdminMiPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
            <br />
	       <ul class="nav menu">
		        <li class="active"><a href="Administrador.aspx"><span class="glyphicon glyphicon-home"></span> Home</a></li>
		        <li><a href="AdminHabilitarUser.aspx"><span class="glyphicon glyphicon-briefcase"></span> Control Usuarios</a></li>
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
                <div align="center">
                    <b>
                        <li class="active">Bienvenido
                            <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                        </li>
                        <b>
                </div>
            </ol>
        </div>
        <div class="row">
            <br />
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading" aling="center">
                        <center><h2>Mi Perfil</h2>
                        </center>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-body">
                            <br />
                            <div class="col-md-12">
                                <div class="form-group">
                                    <center><label>* Nombre Completo</label></center>
                                    <br />
                                    <b><font face="arial" size="4"><center><asp:Label ID="lblPerfil" runat="server" style="text-transform: uppercase;" ></asp:Label></center></font>
                                    </b>
                                </div>
                                <div class="form-group">
                                    <center><label>* Rut</label></center>
                                    <br />
                                    <font face="arial" size="4"><center><asp:Label ID="lblRut" runat="server" style="text-transform: uppercase;" Text="Label"></asp:Label></center></font>
                                    </b>
                                </div>
                                <div class="form-group">
                                    <center><label>* Email</label></center>
                                    <br />
                                    <b><font face="arial" size="4"><center><asp:Label ID="lblEmail" runat="server" style="text-transform: uppercase;" Text="Label"></asp:Label></center></font>
                                    </b>
                                </div>
                                <div class="form-group">
                                    <center><label>* Telefono</label></center>
                                    <br />
                                    <b><font face="arial" size="4"><center><asp:Label ID="lblTelefono" runat="server" style="text-transform: uppercase;" Text="Label"></asp:Label></center></font>
                                    </b>
                                </div>
                                <div class="form-group">
                                    <center><label>* Nombre Usuario</label></center>
                                    <br />
                                    <b><font face="arial" size="4"><center><asp:Label ID="lblNombreUser" runat="server" style="text-transform: uppercase;" Text="Label"></asp:Label></center></font>
                                    </b>
                                </div>
                                <div class="form-group">
                                    <center><label>* Privilegios</label></center>
                                    <br />
                                    <b><font face="arial" size="4"><center><asp:Label ID="lblPrivilegios" runat="server" style="text-transform: uppercase;" Text="Label"></asp:Label></center></font>
                                    </b>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /.col-->
                </div>
                <!-- /.row -->
            </div>
            <!--/.main-->
        </div>
    </div>
</asp:Content>
