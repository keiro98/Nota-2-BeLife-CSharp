   M S B A M L   `   `   `  ���� U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  C ?metrowpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:metrowpfmetrowpf    metrowpf.Listadoclientes   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  "localclr-namespace:metrowpf  -     � Title$  Listado de clientes��$��679.5��$��891.5�� � WindowStartupLocation$ CenterScreen=�
�������.��� .+��� $
��Left=�$��46��$��	10,10,0,0q�$	��Top=�$	��181��$
��Fill=�$��imagenes/Logo BeLife.png���� $��Listado de clientes��$
��Left=�$��
284,91,0,0q�$	��Top=�$��36(�
������ ���	#FF9F37FF�� -    ��Name$ 	txtbuscar��$
��Left=�$��27��$��238,237,0,0q�*   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$= 7Ingrese el rut del cliente que desea buscar o eliminar �� �� TextWrapping$
 Wrap=�$	��Top=�$	��365��
���   ��� -    ��Name$ btnrefrescar��$ ��        Refrescar Ventana
��$
��Left=�$��721,593,0,0q�$	��Top=�$	��142�� J� RenderTransformOrigin$ 
2.32,11.37&�
���   �$��33�����	#FF9F37FF&   System.Windows.Controls.DataGrid  -     Name$ datagridcliente��$
��Left=�$	��258��$��125,316,0,0q�$	��Top=�$	��671�����	#CC000000�� -   $ 	btnbuscar��$��         Buscar��$
��Left=�$��623,237,0,0q�$	��Top=�$��77��$ 0.466,0.111&�
���   ����	#FF9F37FF"  FontAwesome.WPF.ImageAwesome  -   	  Name$
	 lupa��
   Icon$
 Search=�$��634,237,237,385q�$ 	0.5,0.759&��� -   $ btneliminar��$��Eliminar��$
��Left=�$��714,274,0,0q�$	��Top=�$��77��$ 2.293,1.519&����	#FF9F37FF
���   �!  FontAwesome.WPF.FontAwesome  -     Name$ basura��   Icon$ Trash=�$��682,281,132,320q�$ 	1.1,0.646&�  $
 Refresh=�$��721,593,148,23q�$ 
0.182,-0.2&�$��13���� -	   $ btnmodificarc��$��	Modificar��$
��Left=�$��714,237,0,0q�$	��Top=�$��77��$ 0.067,0.537&�$��27�����	#FF9F37FF
���   ��� -
   $ 	btncrearc��$��Crear��$
��Left=�$��623,274,0,0q�$	��Top=�$��77��$ 0.067,0.537&�$��27�����	#FF9F37FF
���   �!   MahApps.Metro.Controls.Tile  -   $��770,14,39,553q�$
��Auto��   Title$  ��$
��Auto����Z� .���� $C��=C:\Users\keiro\source\repos\metrowpf\imagenes\left-arrown.png��$	��136��$��82��$ 0.527,0.379&� J� OpacityMask
 �   �#   MahApps.Metro.Controls.Flyout  -     Name$ flypro��   Position$ Right=����	#FF9F37FF$��Actualizar Cliente��4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�$	��292��.���� $	��574��.+�  $	��178��$	��178�� �� Left$ 58�����	#FF9F37FF$��0q�
 �� Top$	 -23���� $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��$	��128��$	��114��$ 74��$ 10���� -   $ txtrut��$��23��$
 Wrap=�$	��Top=�$	��232�� . $, &Ingrese el rut del cliente a modificar��$ 30��$	 160��
���   ��� -   $ 	txtnombre��$��23��$
 Wrap=�$	��Top=� . $ Ingrese el nombre nuevo��$ 30��$	 208��$	��232��
���   ��� -   $ txtapellido��$��23��$
 Wrap=�$	��Top=�$	��232�� . $ Ingrese el apellido nuevo��$ 30��$	 254��
���   ��� -   $ txtfechanac��$��42��$
 Wrap=�$	��Top=�$	��232�� . $* $Ingrese la fecha de nacimiento nueva��$ 30��$	 300��
���   ��� -    ��Name$ cbxsexo��$	 134��$	 372��$	��128��$��34��$ 0.785,0.441&�
���   ��� -   $ cbxestadocivil��$��34��$	 134��$	 426��$	��128��
���   ��� $
��Sexo��$
��Left=�$	��Top=�$ 58��$	 380��$��56���� $��Estado CIvil��$
��Left=�$	��Top=�$ 43��$	 434��$ 0.831,0.481&��� -   $ btnactualizar��$��
Actualizar��$
��Left=�$��76��$	 101��$	 527��
���   �G� -    G�Name$ pbcontraseña��$
��Left=�$	��Top=� . $% Introduzca la nueva contraseña�� "  MetroButtonRevealedPasswordBox#��[  $ 13.906,1.615&�$ 30��$	 483��$	��232��$��23��
���   �