   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   
   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5	   	   C ?metrowpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:metrowpfmetrowpf 5
   	      metrowpf.Listadoclientes   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   
   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	   	   "localclr-namespace:metrowpf  5
   	   -   5          � Title$  Listado de clientes��5   	   $��679.5��6%   $��891.5��64    � WindowStartupLocation$ CenterScreen=�6B   
�������.��5      � .+�5   
   �� $
��Left=�6   $��46��6+   $��	10,10,0,0q�67   $	��Top=�6J   $	��181��6b   $
��Fill=�6n   $��imagenes/Logo BeLife.png��6}   �� 5   
   $��Listado de clientes��6   $
��Left=�6.   $��
284,91,0,0q�6I   $	��Top=�6]   $��36(�6u   
������ ���	#FF9F37FF6�   �� 5   
   -   5         ��Name$ 	txtbuscar��5      $
��Left=�6%   $��27��6@   $��238,237,0,0q�6L   *   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$= 7Ingrese el rut del cliente que desea buscar o eliminar ��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��365��6  
���   �66  �� 5   
   -   5         ��Name$ btnrefrescar��5      $ ��        Refrescar Ventana
��6'   $
��Left=�6P   $��721,593,0,0q�6k   $	��Top=�6�   $	��142��6�    J� RenderTransformOrigin$ 
2.32,11.37&�6�   
���   �$��33��6�   ���	#FF9F37FF6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagridcliente��5      $
��Left=�6,   $	��258��6G   $��125,316,0,0q�6T   $	��Top=�6i   $	��671��6�   ���	#CC0000006�   �� 5   
   -   5        $ 	btnbuscar��5      $��         Buscar��6$   $
��Left=�6>   $��623,237,0,0q�6Y   $	��Top=�6n   $��77��6�   $ 0.466,0.111&�6�   
���   ����	#FF9F37FF6�   "  FontAwesome.WPF.ImageAwesome  5   
   -   5        	  Name$
	 lupa��5      
   Icon$
 Search=�6(   $��634,237,237,385q�66   $ 	0.5,0.759&�6O   �� 5   
   -   5        $ btneliminar��5      $��Eliminar��6&   $
��Left=�69   $��714,274,0,0q�6T   $	��Top=�6i   $��77��6�   $ 2.293,1.519&�6�   ���	#FF9F37FF
���   �6�   !  FontAwesome.WPF.FontAwesome  5   
   -   5          Name$ basura��5         Icon$ Trash=�6)   $��682,281,132,320q�66   $ 	1.1,0.646&�6O     5   
   $
 Refresh=�6   $��721,593,148,23q�6)   $ 
0.182,-0.2&�6A   $��13��6d   �� 5   
   -	   5        $ btnmodificarc��5      $��	Modificar��6(   $
��Left=�6<   $��714,237,0,0q�6W   $	��Top=�6l   $��77��6�   $ 0.067,0.537&�6�   $��27��6�   ���	#FF9F37FF
���   �6�   �� 5   
   -
   5        $ 	btncrearc��5      $��Crear��6$   $
��Left=�64   $��623,274,0,0q�6O   $	��Top=�6d   $��77��6|   $ 0.067,0.537&�6�   $��27��6�   ���	#FF9F37FF
���   �6�   !   MahApps.Metro.Controls.Tile  5   
   -   5        $��770,14,39,553q�5      $
��Auto��6/      Title$  ��6<   $
��Auto��6E   ��6h   Z� .��5      �� $C��=C:\Users\keiro\source\repos\metrowpf\imagenes\left-arrown.png��6   $	��136��6[   $��82��6g   $ 0.527,0.379&�6s    J� OpacityMask
 �   �6�   5      #   MahApps.Metro.Controls.Flyout  5   
   -   5          Name$ flypro��5         Position$ Right=�6*   ���	#FF9F37FF$��Actualizar Cliente��6R   4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�6n   $	��292��6�   .��5      �� $	��574��6   .+�5         $	��178��6    $	��178��6,    �� Left$ 58��69   ���	#FF9F37FF$��0q�6b   
 �� Top$	 -23��6m   �� 5!      $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��6   $	��128��6`   $	��114��6l   $ 74��6y   $ 10��6�   �� 5"      -   5        $ txtrut��5"      $��23��6*   $
 Wrap=�66   $	��Top=�6J   $	��232��6b    . $, &Ingrese el rut del cliente a modificar��6�   $ 30��6�   $	 160��6�   
���   �6  �� 5#      -   5        $ 	txtnombre��5#      $��23��6-   $
 Wrap=�69   $	��Top=�6M    . $ Ingrese el nombre nuevo��6�   $ 30��6�   $	 208��6�   $	��232��6�   
���   �64  �� 5$      -   5        $ txtapellido��5$      $��23��6/   $
 Wrap=�6;   $	��Top=�6O   $	��232��6g    . $ Ingrese el apellido nuevo��6�   $ 30��6�   $	 254��6�   
���   �6D  �� 5%      -   5        $ txtfechanac��5%      $��42��6/   $
 Wrap=�6;   $	��Top=�6O   $	��232��6g    . $* $Ingrese la fecha de nacimiento nueva��6�   $ 30��6�   $	 300��6�   
���   �6K  �� 5&      -   5         ��Name$ cbxsexo��5&      $	 134��6,   $	 372��6>   $	��128��6O   $��34��6[   $ 0.785,0.441&�6g   
���   �6�   �� 5'      -   5        $ cbxestadocivil��5'      $��34��63   $	 134��6?   $	 426��6Q   $	��128��6b   
���   �6�   �� 5(      $
��Sexo��6   $
��Left=�6'   $	��Top=�6B   $ 58��6Z   $	 380��6k   $��56��6|   �� 5)      $��Estado CIvil��6   $
��Left=�6/   $	��Top=�6J   $ 43��6b   $	 434��6s   $ 0.831,0.481&�6�   �� 5*      -   5        $ btnactualizar��5*      $��
Actualizar��60   $
��Left=�6E   $��76��6`   $	 101��6k   $	 527��6}   
���   �6�   G� 5+      -   5         G�Name$ pbcontraseña��5+      $
��Left=�64   $	��Top=�6O    . $% Introduzca la nueva contraseña��6�    "  MetroButtonRevealedPasswordBox#��[  6�   $ 13.906,1.615&�6  $ 30��64  $	 483��6E  $	��232��6V  $��23��6b  
���   �6�  5,      5/      51      52      