   M S B A M L   `   `   `  ����E  AMainPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MainPlugin.PressKeyMainPlugin.PressKey  5      /    )MainPlugin.PressKey.PressKey_ParamsDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:MainPlugin.PressKey     5        � Title$,  &Appuyer automatiquement sur une touche��5       � 
ResizeMode$ NoResize=�61    � SizeToContent$ WidthAndHeight=�6G    � WindowStartupLocation$ CenterScreen=�6f    � 	Resources 5	         ControlsStyle �� 
TargetType �� Property �� Value �� BasedOn�� 5
   
   %�   &	        '�� H     7   �� 5      " ��6*   .�5      ��  � ��$ 16(�6-   5      �� 5      " ��6   8   .�5      ��  � ��
 �   �6/   �� 5       � �� �	#FFDDDDDD6/   5      5      .��5      � .+�5   
   �� -   5        	 ��Name$	 BT_Help��5      $
��Aide��6"   $��Right=�61   $	��Top=�6M   $��11(�6e   6s   �� 5   
   
 �� Orientation$
 Vertical=�6   .+�5      �� $
 Vertical=�6   $��10, 5q�60   .+�5      �� $1��+Saisissez la ou les touches à déclacher :��6   �� 5      -   5         ��Name$ TB��5      $	��100��6&   5      �� 5      -   5        $	 BT_Validate��5      $��Valider��6*   $��2q�6<   6G   5      5      5      