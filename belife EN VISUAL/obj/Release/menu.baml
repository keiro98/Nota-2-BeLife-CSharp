   M S B A M L   `   `   `  ���� C  ?metrowpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:metrowpfmetrowpf  U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls     metrowpf.menuxaml   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:metrowpf     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  Q MControlzEx, Version=4.0.0.0, Culture=neutral, PublicKeyToken=69f1c32f803d307e
controlzexurn:controlzex  -     � Title$  Menú��$��745.5��$��582.5�� � WindowStartupLocation$ CenterScreen=�.��� $��0,0,2,0q�.+��� $
��Left=�$��46��$��	10,10,0,0q�$	��Top=�$	��181��$
��Fill=�$��imagenes/Logo BeLife.png��!  MahApps.Metro.Controls.Tile  -   $��13,116,381,421q�$	��178��   Title$ 
Ver Perfil��$
��Auto��%  ControlzEx.KeyboardNavigationEx   AlwaysShowFocusVisual . .���� $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��$	��260��$	��119��  -   $��379,309,15,228q�$	��178��$ Ayuda��$	��178��.���� $A��;C:\Users\keiro\source\repos\metrowpf\imagenes\Help - 02.png��$	��150��$	��135��  -   $��379,116,15,421q�$	��178��$ Planes��$	��178��.���� $@��:C:\Users\keiro\source\repos\metrowpf\imagenes\Bill2-WF.png��$	��150��$	��135��  -   $��196,309,198,228q�$	��178��$ 	Contratos��$
��Auto��.���� $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\agreement-02.png��$	��260��$	��119��  -   $��13,309,381,228q�$	��178��$# Añadir o modificar contratos��$	��178��.���� $?��9C:\Users\keiro\source\repos\metrowpf\imagenes\add-new.png��$	��146��$	��106�� J� RenderTransformOrigin$ 0.527,0.379&�  -   $��196,116,198,421q�$	��178��$ Listado de clientes��$	��178��.���� -    ��Name$ btnlListado��$A��;C:\Users\keiro\source\repos\metrowpf\imagenes\search-wf.png��$	��150��$	��135��  -	     Name$ tileajustes��$��13,502,381,35q�$	��178��$ Ajustes��$	��178��.���� -
   $ 
btnajustes��$@��:C:\Users\keiro\source\repos\metrowpf\imagenes\settings.png��$	��150��$	��135��  -   $��196,502,198,35q�$	��178��$ Salir��$	��178��.���� -   $ btnsalir��$<��6C:\Users\keiro\source\repos\metrowpf\imagenes\exit.png��$	��150��$	��135��#  MahApps.Metro.Controls.Flyout  -     Name$ flyproayuda��$��	1,0,0,289q�$	��348��$��Ayuda��.���� $��0,0,10,0q�.+��� -    �� Left$ 10��
	 �� Top$	 -3��$	��163��$	��163��$��Manual de usuario��$��14(�$ 0.207,0.353&�
���   ���Z� �� $����Dirección del servicio técnico: Vicuña
Mackenna 4917,San Joaquín, Región
Metropolitana.


Correo de servicio técnico: cetecom@duoc.cl

Numero de servicio tecnico:(2) 2560 6700��$		 165��$	��186��$��16(�$	��353��$
��Bold"��� -   
 ��Name$
 	lblnombre��$�� ��$
��Left=�$��	332,5,0,0q�$	��Top=�$	��230��$��46���� -   $
 lbldatetime��$��
��$
��Left=�$��46��$��
332,33,0,0q�$	��Top=�$	��230��  -   $ 	flyperfil��$��Ver Perfil	             ��$��1,3,0,23q�$	��326��.���� .+�  -   $	��196��$	��178��$ 60��$��0q�$	 10����Z� �� $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��$	��128��$	��114��$ 93��$	 33���� $��Usuario:��$
��Left=�$	��Top=�$ 22��$		 234��$��16(��� -   $
 
lblusuario��$ 93��$		 234��$��31��$	��215�����	#00000000$��16(�$��
���� $
��Rut:��$
��Left=�$	��Top=�$ 34��$		 301��$��16(�$ 1.235,0.145&��� -   $
 lblrut��$ 93��$		 301��$��31��$	��196�����	#00000000$��16(��� -   $
 lblcargo��$��Cargo:��$
��Left=�$	��Top=�$ 22��$		 362��$��16(�$ 0.586,-0.71&��� $ 93��$		 362��$��32��$	��196�����	#00000000$��Administrador��$��16(��� $��Fecha de ingreso:��$
��Left=�$	��Top=�$ 22��$		 424��$��16(�$ 0.586,-0.71&��� -   $
 	lblfechai��$	 157��$		 423��$��32��$��96�����	#00000000$�� ��$��16(��� -    ��Name$ 
btncamcont��$��Cambiar contraseña��$
��Left=�$	��Top=�$	��145��$ 93��$		 488��
���   ���Z� �� -   $ 93��$		 543��$	��145��$��27��
���   �$��Cambiar Informacion����Z�   -   $ flycambcontra��   Position$	 Top=�$	��310��$��
46,-1,28,0q�.���� $	��428��.+��� $ 93��$	 62��$��Cambiar Contraseña��$��20(�G� -    G�Name$ pbconactual��$ 44��$		 132��$	��298��*  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .  "  MetroButtonRevealedPasswordBox#��[     	Watermark$# Escriba su contraseña actual��G� -   $ 
pbconnueva��$ 44��$		 178��$	��298�� . #��[  $" Escriba la nueva contraseña��G� -   $ pbconnuevare��$ 44��$		 224��$	��298�� . $+ %Escriba otra vez la nueva contraseña��#��[  �� -   $ 
btnaceptar��$	 124��$		 272��$	��112��$��Aceptar��  -   $ flyprocambinfo��$ Right=�$	��286��$��	0,0,0,108q�$��Cambiar informacion��.���� .+�  $	��178��$	��178��$ 58��$��0q�$		 -23����Z� �� $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��$	��128��$	��114��$ 90��$	 10���� -    ��Name$ 	txtnombre��$��23�� �� TextWrapping$
 Wrap=�$	��Top=� . $ Ingrese el nombre nuevo��$ 30��$		 208��$	��232��
���   ��� -    $ txtfechanacimiento��$��23��$
 Wrap=�$	��Top=�$	��232�� . $+ %Ingrese la fecha de nacimiento nueva ��$ 30��$		 254��
���   ��� -!   $ txtfechaingreso��$��23��$
 Wrap=�$	��Top=�$	��232�� . $' !Ingrese la fecha de ingreso nueva��$ 30��$		 300��
���   ��� -"    ��Name$ cbxsexo��$	 134��$		 355��$	��128��$��34��$ 0.785,0.441&�
���   ��� -#   $ cbxestadocivil��$��34��$	 134��$		 409��$	��128��
���   ��� $
��Sexo��$
��Left=�$	��Top=�$ 73��$		 362��$��56���� $��Estado CIvil��$
��Left=�$	��Top=�$ 58��$		 416��$ 0.831,0.481&��� -$   $ btnactualizar��$��
Actualizar��$
��Left=�$��76��$	 113��$		 474��
���   �  -%   $ flyproajustes��$��-339,-23,0,23q�$	��304��$��Ajustes��.���� 