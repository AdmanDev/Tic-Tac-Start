   M S B A M L   `   `   `  ����E  AMainPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:MainPlugin.ShutDown_Restart_PCMainPlugin.ShutDown_Restart_PC  5      E    ?MainPlugin.ShutDown_Restart_PC.ShutDown_Restart_PC_ParamsDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:MainPlugin.ShutDown_Restart_PC     5        � Title$"  Arrêter / Redémarrer le PC��5       � 
ResizeMode$ NoResize=�61    � SizeToContent$ WidthAndHeight=�6G    � WindowStartupLocation$ CenterScreen=�6f    � 	Resources 5	         ControlsStyle �� 
TargetType �� Property �� Value �� BasedOn��%�   &	        '�� H     7   �� 5
   
   " ��6&   .�5      ��  � ��$ 16(�6)   5      �� 5   
   " ��6   8   .�5      ��  � ��
 �   �6+   �� 5       � �� �	#FFDDDDDD6+   5      5      .��5      � $	��250��6   $��70��6   $��15q�6#   .+�5   
   	� -   5        	 	�Name$	 RB_ShutDown��5      $��Arrêter le PC��6+   
 d� 	IsChecked$

 TrueY�6C   $
��Left=�6T   	� 5   
   -   5        $	 
RB_Restart��5      $��Redémarrer le PC��6*   $��Right=�6E   �� 5   
   -   5         ��Name$ BT_OK��5      $��OK��6    $��0, 10, 0, 0q�6-    �� 	IsDefault . $��20(�6S   
���   �$��Bottom=�6t   6�   5      5      