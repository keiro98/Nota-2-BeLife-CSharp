   M S B A M L   `   `   `  ����C  ?metrowpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:metrowpfmetrowpf  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	       metrowpf.menuxaml   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:metrowpf     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	   	   Q MControlzEx, Version=4.0.0.0, Culture=neutral, PublicKeyToken=69f1c32f803d307e
controlzexurn:controlzex  5
   	   -   5          � Title$  Menú��5   	   $��745.5��6   $��582.5��6%    � WindowStartupLocation$ CenterScreen=�63   .��5      � $��0,0,2,0q�6   .+�5   
   �� $
��Left=�6   $��46��6+   $��	10,10,0,0q�67   $	��Top=�6J   $	��181��6b   $
��Fill=�6n   $��imagenes/Logo BeLife.png��6}   !  MahApps.Metro.Controls.Tile  5   
   -   5        $��13,116,381,421q�5      $	��178��60      Title$ 
Ver Perfil��6<   $
��Auto��6O   %  ControlzEx.KeyboardNavigationEx   AlwaysShowFocusVisual . .��5      �� $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��6   $	��260��6\   $	��119��6h   5        5   
   -   5        $��379,309,15,228q�5      $	��178��60   $ Ayuda��6<   $	��178��6J   .��5      �� $A��;C:\Users\keiro\source\repos\metrowpf\imagenes\Help - 02.png��6   $	��150��6Y   $	��135��6e   5        5   
   -   5        $��379,116,15,421q�5      $	��178��60   $ Planes��6<   $	��178��6K   .��5      �� $@��:C:\Users\keiro\source\repos\metrowpf\imagenes\Bill2-WF.png��6   $	��150��6X   $	��135��6d   5        5   
   -   5        $��196,309,198,228q�5      $	��178��61   $ 	Contratos��6=   $
��Auto��6O   .��5      �� $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\agreement-02.png��6   $	��260��6\   $	��119��6h   5        5   
   -   5        $��13,309,381,228q�5      $	��178��60   $# Añadir o modificar contratos��6<   $	��178��6a   .��5      �� $?��9C:\Users\keiro\source\repos\metrowpf\imagenes\add-new.png��6   $	��146��6W   $	��106��6c    J� RenderTransformOrigin$ 0.527,0.379&�6p   5        5   
   -   5        $��196,116,198,421q�5      $	��178��61   $ Listado de clientes��6=   $	��178��6Y   .��5       �� -   5         ��Name$ btnlListado��5       $A��;C:\Users\keiro\source\repos\metrowpf\imagenes\search-wf.png��6)   $	��150��6n   $	��135��6z   5!        5"   
   -	   5        $��10,496,384,41q�5"      $	��178��6/   $ Salir��6;   $	��178��6I   .��5#      �� -
   5        $ btnsalir��5#      $<��6C:\Users\keiro\source\repos\metrowpf\imagenes\exit.png��6&   $	��150��6f   $	��135��6r   5$      #  MahApps.Metro.Controls.Flyout  5&   
   -   5          Name$ flyproayuda��5&      $��	1,0,0,289q�6/   $	��348��6B   $��Ayuda��6N   .��5'      �� $��0,0,10,0q�6   .+�5(      �� -   5         �� Left$ 10��5(      
 �� Top$ -3��6*   $	��163��6:   $	��163��6[   $��Manual de usuario��6h   $��14(�6�   $ 0.207,0.353&�6�   
���   ���6�   Z� 6�   �� 5)      $����Dirección del servicio técnico: Vicuña
Mackenna 4917,San Joaquín, Región
Metropolitana.


Correo de servicio técnico: cetecom@duoc.cl

Numero de servicio tecnico:(2) 2560 6700��6   $	 165��6  $	��186��6"  $��16(�6/  $	��353��6=  $
��Bold"�6I  5*      5+      �� 5,   
   -   5        	 ��Name$	 	lblnombre��5,      $�� ��6#   $
��Left=�6.   $��	332,5,0,0q�6I   $	��Top=�6\   $	��230��6t   $��46��6�   �� 5-   
   -   5        $	 lbldatetime��5-      $��
��6%   $
��Left=�65   $��46��6P   $��
332,33,0,0q�6\   $	��Top=�6p   $	��230��6�     5.   
   -   5        $ 	flyperfil��5.      $��Ver Perfil	             ��6.   $��0,4,0,22q�6T   $	��326��6f   .��5/      �� .+�50        -   5        $	��196��50       $	��178��6,   $ 60��69   $��0q�6L   $ 10��6W   ��6g   Z� 6}   �� 51      $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��6   $	��128��6`   $	��114��6l   $ 93��6y   $ 33��6�   6�   �� 52      $��Usuario:��6   $
��Left=�6+   $	��Top=�6F   $ 22��6^   $	 234��6o   $��16(�6�   �� 53      -   5        $	 
lblusuario��53      $ 93��6,   $	 234��6=   $��31��6N   $	��215��6Z   ���	#00000000$��16(�6}   $��
��6�   �� 54      $
��Rut:��6   $
��Left=�6'   $	��Top=�6B   $ 34��6Z   $	 301��6k   $��16(�6|   $ 1.235,0.145&�6�   �� 55      -   5        $	 lblrut��55      $ 93��6(   $	 301��69   $��31��6J   $	��196��6V   ���	#00000000$��16(�6y   �� 56      -   5        $	 lblcargo��56      $��Cargo:��6*   $
��Left=�6;   $	��Top=�6V   $ 22��6n   $	 362��6   $��16(�6�   $ 0.586,-0.71&�6�   �� 57      $ 93��6   $	 362��6)   $��32��6:   $	��196��6F   ���	#00000000$��Administrador��6i   $��16(�6�   �� 58      $��Fecha de ingreso:��6   $
��Left=�64   $	��Top=�6O   $ 22��6g   $	 424��6x   $��16(�6�   $ 0.586,-0.71&�6�   �� 59      -   5        $	 	lblfechai��59      $	 157��6+   $	 423��6=   $��32��6N   $��96��6Z   ���	#00000000$�� ��6|   $��16(�6�   �� 5:      -   5        
 ��Name$
 
btncamcont��5:      $��Cambiar contraseña��6-   $
��Left=�6J   $	��Top=�6e   $	��145��6}   $ 93��6�   $	 488��6�   
���   ���6�   Z� 6�   �� 5;      -   5        $ 93��5;      $	 543��6*   $	��145��6;   $��27��6G   
���   �$��Cambiar Informacion��6}   ��6g   Z� 6�   5=      5>        5?   
   -   5        $ flycambcontra��5?         Position$	 Top=�61   $	��310��6@   $��
46,-1,28,0q�6M   .��5@      �� $	��428��6   .+�5A      �� $ 93��6   $ 62��6)   $��Cambiar Contraseña��69   $��20(�6V   6f   G� 5B      -   5         G�Name$ pbconactual��5B      $ 44��63   $	 132��6D   $	��298��6U   *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .  "  MetroButtonRevealedPasswordBox#��[  6�      	Watermark$# Escriba su contraseña actual��6�   68  G� 5C      -   5        $ 
pbconnueva��5C      $ 44��62   $	 178��6C   $	��298��6T    . #��[  6�   $" Escriba la nueva contraseña��6�   64  G� 5D      -   5        $ pbconnuevare��5D      $ 44��64   $	 224��6E   $	��298��6V    . $+ %Escriba otra vez la nueva contraseña��6�   #��[  6�   6A  �� 5E      -   5        $
 
btnaceptar��5E      $	 124��6-   $	 272��6?   $	��112��6P   $��Aceptar��6\   6�   5F      5G        5I   
   -   5        $ flyprocambinfo��5I      $ Right=�62   $	��286��6C   $��	0,0,0,108q�6O   $��Cambiar informacion��6b   .��5K      �� .+�5L        $	��178��6    $	��178��6,   $ 58��69   $��0q�6a   $	 -23��6l   ��6K   Z� 6l   �� 5M      $D��>C:\Users\keiro\source\repos\metrowpf\imagenes\user-profile.png��6   $	��128��6`   $	��114��6l   $ 90��6y   $ 10��6�   �� 5N      -   5         ��Name$ 	txtnombre��5N      $��23��6-    �� TextWrapping$
 Wrap=�69   $	��Top=�6M    . $ Ingrese el nombre nuevo��6�   $ 30��6�   $	 208��6�   $	��232��6�   
���   �66  �� 5O      -   5        $ txtfechanacimiento��5O      $��23��66   $
 Wrap=�6B   $	��Top=�6V   $	��232��6n    . $+ %Ingrese la fecha de nacimiento nueva ��6�   $ 30��6�   $	 254��6  
���   �6T  �� 5P      -   5        $ txtfechaingreso��5P      $��23��63   $
 Wrap=�6?   $	��Top=�6S   $	��232��6k    . $' !Ingrese la fecha de ingreso nueva��6�   $ 30��6�   $	 300��6�   
���   �6J  �� 5Q      -    5         ��Name$ cbxsexo��5Q      $	 134��6,   $	 355��6>   $	��128��6O   $��34��6[   $ 0.785,0.441&�6g   
���   �6�   �� 5R      -!   5        $ cbxestadocivil��5R      $��34��63   $	 134��6?   $	 409��6Q   $	��128��6b   
���   �6�   �� 5S      $
��Sexo��6   $
��Left=�6'   $	��Top=�6B   $ 73��6Z   $	 362��6k   $��56��6|   �� 5T      $��Estado CIvil��6   $
��Left=�6/   $	��Top=�6J   $ 58��6b   $	 416��6s   $ 0.831,0.481&�6�   �� 5U      -"   5        $
 btnactualizar��5U      $��
Actualizar��60   $
��Left=�6E   $��76��6`   $	 113��6k   $	 474��6}   
���   �6�   5W      5X      5Z      5[      