   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      C ?metrowpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:metrowpfmetrowpf 5	   	      metrowpf.planes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   "localclr-namespace:metrowpf  5	   	   9Custom,http://metro.mahapps.com/winfx/xaml/controls   5
   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  6E     � Title$  planes��5   	   $��631.5��6   $	��821��6'    � WindowStartupLocation$ CenterScreen=�63   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgplanes��5      $
��Left=�6%   $	��277��6@   $��268,324,0,0q�6M   $	��Top=�6b   $	��348��6z   �� 5   
   $	��181��6   $	��Top=�6   $
��Fill=�64   $��imagenes/Logo BeLife.png��6C   $��	10,10,0,0q�6e   $��46��6x   $
��Left=�6�   �� 5   
   $	��Top=�6   $��
320,94,0,0q�6(   $
��Left=�6<   $��36(�6W   ���	#FF9F37FF$��Lista de planes��6|   
������ 6�   �� 5   
   -   5         ��Name$ 
txtbuscarp��5      $
��Left=�6&   $��27��6A   $��238,237,0,0q�6M   *   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$D >Ingrese el identificador del plan que desea buscar o eliminar ��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  $	��365��6  
���   �6:  !   MahApps.Metro.Controls.Tile  5   
   -   5        $��704,-46,13,383q�5      $
��Auto��6.      Title$  ��6;   $
��Auto��6D   ��6g   Z� .��5      �� $C��=C:\Users\keiro\source\repos\metrowpf\imagenes\left-arrown.png��6   $	��136��6[   $��82��6g    J� RenderTransformOrigin$ 0.527,0.379&�6s   	 J� OpacityMask
	 �   �6�   5      �� 5   
   -   5        
 ��Name$
 
btnbuscarp��5      $��Buscar��6%   $
��Left=�66   $��623,237,0,0q�6Q   $	��Top=�6f   $��77��6~   $ 0.466,0.111&�6�   
���   ����	#FF9F37FF6�   �� 5   
   -   5        $
 btneliminarp��5      $��Eliminar��6'   $
��Left=�6:   $��723,237,0,0q�6U   $	��Top=�6j   $��77��6�   $ 2.293,1.519&�6�   ���	#FF9F37FF
���   �6�   �� 5   
   -   5        $
 	btncrearp��5      $��Crear/Modificar��6$   $
��Left=�6>   $��654,269,0,0q�6Y   $	��Top=�6n   $	��114��6�   $ 0.067,0.537&�6�   $��27��6�   ���	#FF9F37FF
���   �6�   #   MahApps.Metro.Controls.Flyout  5   
   -   5          Name$ FCrearmodificarplan��5   +      Position$ Right=�6   $��Crear/Modificar Plan��6H   $	��297��6f   $��0,0,0,-3q�6r   .��5      �� .+�5      �� -   5        $ 	txtidplan��5      $��23��6-   $
 Wrap=�69   $	��Top=�6M   $	��259��6e    . $0 *Identificador del plan a crear o modificar��6�    �� Left$ 13��6�   
 �� Top$ 34��6�   
���   �6"  �� 5      -	   5        $ 
txtnombrep��5      $��23��6.   $
 Wrap=�6:   $	��Top=�6N    . $) #Nombre del plan a crear o modificar��6�   $ 13��6�   $ 85��6�   $	��259��6�   
���   �6A  �� 5      -
   5        $ txtaprimabase��5      $��23��61   $
 Wrap=�6=   $	��Top=�6Q   $	��259��6i    . $" Prima base a crear o modicar��6�   $ 13��6�   $	 133��6�   
���   �6  �� 5      -   5        $ txtpolizaactual��5      $��26��63   $
 Wrap=�6?   $	��Top=�6S   $	��259��6k    . $( " Poliza actual a crear o modificar��6�   $ 13��6�   $	 178��6�   
���   �6!  �� 5      -   5        $
 btncreaplan��5      $��
Crear plan��6.   $ 42��6C   $	 242��6T   
���   ���6|   Z� 6�   �� 5       -   5        $
 btnmodificarp��5       $��Modificar plan��60   $	 153��6I   $	 242��6[   
���   ���6�   Z� 6�   5!      5"      5#      5$      