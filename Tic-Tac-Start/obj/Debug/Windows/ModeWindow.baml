   M S B A M L   `   `   `  ����F  BMyFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctionsMyFunctions.ControlsWPF  5   	   H DTic-Tac-Start, Version=2.3.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Tic_Tac_StartTic_Tac_Start 5   	      Tic_Tac_Start.ModeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jmyf:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctions     5   	   -localclr-namespace:Tic_Tac_Start     5   	   -   5          � Title$
  Mode��5	   	   
�������$	��400��6)      WinStyle#���   5
   	    � WindowStartupLocation$ CenterScreen=�6,    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6D     5   
   -   5        $
 Open��5      6E     5   
   -   5        $
 Save��5      6E     5   
   -   5        $ SaveAs��5      6G   .��5      ��  �� Orientation$ Vertical=�6   .+�5   
      Tic_Tac_Start.WindowHeader  �� 5   
   $ Vertical=�6    � 	Resources 5       �� 
TargetType �� Property �� Value��%T   '��       �� 5      " ��6   .�5      ��  � ��$
 0,10q�6/   5      5      .+�5      o� .@�5      m� $��Fichier��6   .@�5      m� $��Nouveau��6   	 m� Command$		 New��60   m� 5      $��Ouvrir��6   $
	 Open��6/   m� 5      $��Enregistrer��6   $
	 Save��64   m� 5      $��Enregistrer sous...��6   $	 SaveAs��6<   5      5       �� 5"      $��Séléctionner le mode :��6   .��5#      �� $ Vertical=�6   .+�5$      �� $ 
Horizontal=�6!   $��Center=�6:   $��0, 10q�6W    5%      ��%y   '	�       �� 5&      " 	�6$   .�5'   "   ��  � ��$	 8,0q�6;   �� 5(   "    � ��
 �����6?   5)      5*      .+�5+      	� -   5        
 	�Name$
 RB_Timer��5+   &   $��Minuteur��68    d� 	IsChecked$
 TrueY�6K   
 � Tag$ DefaultTimerMode��6\   6s   	� 5,      -   5        $
 RB_StopWatch��5,   &   $��Chronomètre��6<   $ StopWatchTimerMode��6R   6k   	� 5-      -   5        $
 RB_ClockTime��5-   &   $��Réveil��6<   $ AlarmClockTimerMode��6M   6g   5.      �� 5/      $ Vertical=�6!   $��Stretch=�68   .+�50      �  � ColumnDefinitions 51      �� 52   "   $��* �63   �� 53   "   $��* �63   �� 54   "   $��* �63   �� 55   "   $��* �63    57      ��%�   '��       �� 58   "   " ��6(   .�59   &   ��  � ��
 �����6C   �� 5:   &    � ��$ 0q�6@   �� 5;   &    � ��$ Center=�6S   5<   #   5=      .+�5>      �� $��Valeur :��6$   $��Center=�67   $��0��6Y   �� 5?      $ Vertical=�6)   $��1��6@   .+�5@   "   +   %MyFunctions.ControlsWPF.NumericUpDown  -	   5          Name$ NUD_Hour��5@   4   
   Min$ 0Q�6F   
   Max$ 59Q�6N   �� 5A   "   $��Heure(s)��6(   5B      �� 5C      $ Vertical=�6)   $��2��6@   .+�5D   "     -
   5        $ 
NUD_Minute��5D   4   $ 0Q�6H   $ 59Q�6P   �� 5E   "   $��	Minute(s)��6(   5F      �� 5G      $ Vertical=�6)   $��3��6@   .+�5H   "     -   5        $ 
NUD_second��5H   4   $ 0Q�6H   $ 59Q�6P   �� 5I   "   $��
Seconde(s)��6(   5J      5K      5L      5M      5N      �� 5O      $��	Actions :��6   .��5P      �� $ Vertical=�6   .+�5Q      �� $ 
Horizontal=�6!   $��Center=�6:   .+�5R      �� -   5         ��Name$ BT_AddPlugin��5R   !   $��Ajouter un plugin��67   $
��5, 0q�6S     SecondaryButtonStyle#��[ 6a   6�   �� 5S      -   5        $ BT_PluginTutorial��5S   !   $
��5, 0q�6<   
������ 
���   ���6J   Z� .��5T      �� $:��4pack://application:,,,/Resources/Images/HelpIcon.png��6$   5U      �� 5V      -   5        $ BT_PluginsManagers��5V   !   $
��5, 0q�6=   $��Plugin Manager��6K   #��[ 6d   6�   5W      7  1System.Windows.Forms.Integration.WindowsFormsHost  5X      -   5          Name$ WFH_CLB_Plugins��5X   '   $	��200��6@   $��15, 10q�6M   5Y      5Z      �� 5[      -   5        $ 	BT_Finich��5[      $��Terminer��6(   $
��8, 5q�6;   6I   5\      5]      5^      