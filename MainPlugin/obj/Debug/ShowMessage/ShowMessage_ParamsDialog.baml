   M S B A M L   `   `   `  ����F  BMyFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctionsMyFunctions.ControlsWPF  5      E AMainPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MainPlugin.ShowMessageMainPlugin.ShowMessage 5      5   /MainPlugin.ShowMessage.ShowMessage_ParamsDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmyf:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctions     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:MainPlugin.ShowMessage     5        � Title$  Afficher un message��5	       � 
ResizeMode$ NoResize=�6*    � SizeToContent$ WidthAndHeight=�6@    � WindowStartupLocation$ CenterScreen=�6_    � 	Resources 5
         ControlsStyle �� 
TargetType �� Property �� Value �� BasedOn��%�   &	        '�� H     7   �� 5   
   " ��6&   .�5      ��  � ��$ 16(�6)   5      �� 5   
   " ��6   8   .�5      ��  � ��
 �   �6+   �� 5       � �� �	#FFDDDDDD6+   5      5      .��5      � .+�5   
   �� 	 �� Orientation$	 Vertical=�6   $��10q�6,   .+�5      �� $	 
Horizontal=�6   .+�5      �� $��	Message :��6   �� 5      -   5        
 ��Name$
 
TB_Message��5      $	��350��6.   $	��127��6:    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6\   5      �� 5      -   5         ��Name$ BT_OK��5      $��OK��6$   $��0, 10, 0, 0q�61    �� 	IsDefault . $��20(�6W   
���   �6x   5      5      5      