   M S B A M L   `   `   `  ���� F  BMyFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctionsMyFunctions.ControlsWPF  H DTic-Tac-Start, Version=2.3.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Tic_Tac_StartTic_Tac_Start    Tic_Tac_Start.ModeWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Jmyf:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctions     -localclr-namespace:Tic_Tac_Start     -     � Title$
  Mode��
�������$	��400��   WinStyle#���    � WindowStartupLocation$ CenterScreen=� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$	 New��  -   $
 Open��  -   $
 Save��  -   $ SaveAs��.����  �� Orientation$ Vertical=�.+�   Tic_Tac_Start.WindowHeader  �� $ Vertical=� � 	Resources  �� 
TargetType �� Property �� Value��%/   '��       �� " ��.���  � ��$
 0,10q�.+�o� .@�m� $��Fichier��.@�m� $��Nouveau��	 m� Command$		 New��m� $��Ouvrir��$
	 Open��m� $��Enregistrer��$
	 Save��m� $��Enregistrer sous...��$	 SaveAs���� $��Séléctionner le mode :��.���� $ Vertical=�.+��� $ 
Horizontal=�$��Center=�$��0, 10q� ��%F   '	�       �� " 	�.���  � ��$	 8,0q���  � ��
 �����.+�	� -   
 	�Name$
 RB_Timer��$��Minuteur�� d� 	IsChecked$
 TrueY�
 � Tag$ DefaultTimerMode��	� -   $
 RB_StopWatch��$��Chronomètre��$ StopWatchTimerMode��	� -   $
 RB_ClockTime��$��Réveil��$ AlarmClockTimerMode���� $ Vertical=�$��Stretch=�.+��  � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* � ��%^   '��       �� " ��.���  � ��
 �������  � ��$ 0q���  � ��$ Center=�.+��� $��Valeur :��$��Center=�$��0���� $ Vertical=�$��1��.+�+   %MyFunctions.ControlsWPF.NumericUpDown  -	     Name$ NUD_Hour��
   Min$ 0Q�
   Max$ 59Q��� $��Heure(s)���� $ Vertical=�$��2��.+�  -
   $ 
NUD_Minute��$ 0Q�$ 59Q��� $��	Minute(s)���� $ Vertical=�$��3��.+�  -   $ 
NUD_second��$ 0Q�$ 59Q��� $��
Seconde(s)���� $��	Actions :��.���� $ Vertical=�.+��� $ 
Horizontal=�$��Center=�.+��� -    ��Name$ BT_AddPlugin��$��Ajouter un plugin��$
��5, 0q�  SecondaryButtonStyle#��[ �� -   $ BT_PluginTutorial��$
��5, 0q�
������ 
���   ���Z� .���� $:��4pack://application:,,,/Resources/Images/HelpIcon.png���� -   $ BT_PluginsManagers��$
��5, 0q�$��Plugin Manager��#��[ 7  1System.Windows.Forms.Integration.WindowsFormsHost  -     Name$ WFH_CLB_Plugins��$	��200��$��15, 10q��� -   $ 	BT_Finich��$��Terminer��$
��8, 5q�