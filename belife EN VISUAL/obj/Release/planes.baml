   M S B A M L   `   `   `  ���� U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  C ?metrowpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:metrowpfmetrowpf    metrowpf.planes   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  :d2http://schemas.microsoft.com/expression/blend/2008  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  "localclr-namespace:metrowpf  9Custom,http://metro.mahapps.com/winfx/xaml/controls   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/    � Title$  planes��$��631.5��$	��821��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dgplanes��$
��Left=�$	��277��$��268,324,0,0q�$	��Top=�$	��348���� $	��181��$	��Top=�$
��Fill=�$��imagenes/Logo BeLife.png��$��	10,10,0,0q�$��46��$
��Left=��� $	��Top=�$��
320,94,0,0q�$
��Left=�$��36(����	#FF9F37FF$��Lista de planes��
������ �� -    ��Name$ 
txtbuscarp��$
��Left=�$��27��$��238,237,0,0q�*   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$D >Ingrese el identificador del plan que desea buscar o eliminar �� �� TextWrapping$
 Wrap=�$	��Top=�$	��365��
���   �!   MahApps.Metro.Controls.Tile  -   $��704,-46,13,383q�$
��Auto��   Title$  ��$
��Auto����Z� .���� $C��=C:\Users\keiro\source\repos\metrowpf\imagenes\left-arrown.png��$	��136��$��82�� J� RenderTransformOrigin$ 0.527,0.379&� J� OpacityMask
 �   ��� -   	 ��Name$	 
btnbuscarp��$��Buscar��$
��Left=�$��623,237,0,0q�$	��Top=�$��77��$ 0.466,0.111&�
���   ����	#FF9F37FF�� -   $	 btneliminarp��$��Eliminar��$
��Left=�$��723,237,0,0q�$	��Top=�$��77��$ 2.293,1.519&����	#FF9F37FF
���   ��� -   $	 	btncrearp��$��Crear/Modificar��$
��Left=�$��654,269,0,0q�$	��Top=�$	��114��$ 0.067,0.537&�$��27�����	#FF9F37FF
���   �#   MahApps.Metro.Controls.Flyout  -   
  Name$
 FCrearmodificarplan��   Position$ Right=�$��Crear/Modificar Plan��$	��297��$��0,0,0,-3q�.���� .+��� -   $ 	txtidplan��$��23��$
 Wrap=�$	��Top=�$	��259�� . $0 *Identificador del plan a crear o modificar�� �� Left$ 13��
 �� Top$ 34��
���   ��� -	   $ 
txtnombrep��$��23��$
 Wrap=�$	��Top=� . $) #Nombre del plan a crear o modificar��$ 13��$ 85��$	��259��
���   ��� -
   $ txtaprimabase��$��23��$
 Wrap=�$	��Top=�$	��259�� . $" Prima base a crear o modicar��$ 13��$	 133��
���   ��� -   $ txtpolizaactual��$��26��$
 Wrap=�$	��Top=�$	��259�� . $( " Poliza actual a crear o modificar��$ 13��$	 178��
���   ��� -   $	 btncreaplan��$��
Crear plan��$ 42��$	 242��
���   ���Z� �� -   $	 btnmodificarp��$��Modificar plan��$	 153��$	 242��
���   ���Z� 