   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      C ?metrowpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:metrowpfmetrowpf 5
   	   $   metrowpf.formulario_cucontrato   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      "localclr-namespace:metrowpf  5
   	     � Title$*  $Formulario Crear/Actualizar Contrato��5   	   $	��480��66   $��927.5��6C    � WindowStartupLocation$ CenterScreen=�6Q   .��5      � $��0,0,0,1q�6   .+�5   
   �� -   5         ��Name$ 	txtnumero��5      $
��Left=�6%   $��26��6@    �� TextWrapping$
 Wrap=�6L   *   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$+ %N° del contrato a crear o actualizar��6�   $	��Top=�6�   $	��251��6�   $��205,160,0,0q�6�    J� RenderTransformOrigin$ 0.615,0.577&�64  
���   �6l  �� 5   
   -   5        $ txtfechacreacion��5      $
��Left=�6,   $��26��6G   $
 Wrap=�6S    . $% Fecha de creacion del contrato ��6�   $	��Top=�6�   $	��251��6�   $��205,200,0,0q�6�   
���   �6P  �� 5   
   $
��Left=�6   $��46��6+   $��	10,10,0,0q�67   $	��Top=�6J   $	��181��6b   $
��Fill=�6n   $��imagenes/Logo BeLife.png��6}   �� 5   
   -   5        $ txtrutcliente��5      $
��Left=�6)   $��26��6D   $
 Wrap=�6P    . $* $Rut del cliente asociado al contrato��6�   $	��Top=�6�   $	��251��6�   $��205,246,0,0q�6�   
���   �6;  �� 5   
   -   5        $ txtcodigoplan��5      $
��Left=�6)   $��26��6D   $
 Wrap=�6P    . $* $Codigo del plan asociado al contrato��6�   $	��Top=�6�   $	��251��6�   $��205,289,0,0q�6�   
���   �6;  �� 5   
   -   5        $ txtfechainiciovigencia��5      $
��Left=�62   $��26��6M   $
 Wrap=�6Y    . $. (Fecha de inicio de vigencia del contrato��6�   $	��Top=�6�   $	��251��6�   $��205,340,0,0q�6  
���   �6e  �� 5   
   -   5        $ txtfechafinvigencia��5      $
��Left=�6/   $��26��6J   $
 Wrap=�6V    . $, &Fecha del fin de vigencia del contrato��6�   $	��Top=�6�   $	��251��6�   $��205,387,0,0q�6  $ 0.615,0.577&�6I  
���   �6�  �� 5   
   -   5         ��Name$ 
cbxvigente��5      $
��Left=�6'   $��639,165,0,0q�6B   $	��Top=�6W   $	��120��6o   
���   �$ 0.883,0.692&�6�   .@�5      �� $��0��6   $
��Left=�6'   $	��118��6B   �� 5      -   5        $��1��5      $
��Left=�6'   $	��118��6B   6N   5      �� 5   
   -	   5        $ cbxdeclaracion��5      $
��Left=�6+   $��639,207,0,0q�6F   $	��Top=�6[   $	��120��6s   
���   �.@�5      �� $��0��6   $
��Left=�6'   $	��118��6B   �� 5      $��1��6   $
��Left=�6'   $	��118��6B   5      �� 5   
   -
   5        $ txtprimaanual��5      $
��Left=�6)   $��26��6D   $
 Wrap=�6P    . $ Prima anual��6�   $	��Top=�6�   $	��251��6�   $��486,246,0,0q�6�   $ 0.608,-2.173&�6"  
���   �6G  �� 5   
   -   5        $ txtprimamensual��5      $
��Left=�6+   $��26��6F   $
 Wrap=�6R    . $ Prima mensual��6�   $	��Top=�6�   $	��251��6�   $��486,289,0,0q�6�   $ 0.615,0.577&�6(  
���   �6L  �� 5   
   -   5        $ txtobservaciones��5      $
��Left=�6,   $��26��6G   $
 Wrap=�6S    . $ Observaciones��6�   $	��Top=�6�   $	��251��6�   $��486,340,0,0q�6�   $ 0.615,0.577&�6*  
���   �6N  �� 5    
   -   5         ��Name$ 	btncrearc��5       $��Crear��6$   $
��Left=�64   $��513,395,0,0q�6O   $	��Top=�6d   $��76��6|   ���	#FF9F37FF$ 
0.72,0.556&�6�   
���   �6�   �� 5!   
   -   5        $ btnactualizarc��5!      $��
actualizar��6)   $
��Left=�6>   $��614,395,0,0q�6Y   $	��Top=�6n   $��75��6�   ���	#FF9F37FF
���   �6�   �� 5#   
   $��Esta Vigente?��6   $
��Left=�6(   $��546,168,0,0q�6C   $	��Top=�6X   $ 0.474,1.231&�6p   �� 5$   
   $!��Tiene Declaracion de Salud?��6   $
��Left=�66   $��476,208,0,0q�6Q   $	��Top=�6f   !   MahApps.Metro.Controls.Tile  5%   
   -   5        $��834,16,78,376q�5%      $
��Auto��6/   	   Title$	  ��6<   $
��Auto��6E   ��6h   Z� �� 5&   
   $+��%Formulario Crear/Actualizar Contratos��6   $
��Left=�6@   $��
191,56,0,0q�6[   $	��Top=�6o   $��36(�6�   
������ ���	#FF9F37FF6�     5'   
   -   5        $��836,2,10,338q�5'      $
��Auto��6.   $	  ��6;   $
��Auto��6D   ��6g   Z� .��5(      �� $C��=C:\Users\keiro\source\repos\metrowpf\imagenes\left-arrown.png��6   $	��136��6[   $��82��6g   $ 0.527,0.379&�6s   
 J� OpacityMask

 �   �6�   5)      5,      5-      