   M S B A M L   `   `   `  ���� F  BMyFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctionsMyFunctions.ControlsWPF  H DTic-Tac-Start, Version=2.3.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Tic_Tac_StartTic_Tac_Start #   Tic_Tac_Start.AddPluginWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Jmyf:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctions     -localclr-namespace:Tic_Tac_Start       � Title$  Nouveau plugin��   WinStyle#���    � WindowStartupLocation$ CenterScreen=� � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       '�� l     �� " ��.���  � ��$
 0, 5q���  � ��
 �������  � ��$ 16(���  � ��$ Right=��� " ��.���  � ��$ 16(���  � ��$	 0,5q�.����  �� Orientation$ Vertical=�.+�   Tic_Tac_Start.WindowHeader  �� $ Vertical=�$��10q�.+��  � ColumnDefinitions �� $��* ��� $��* �.+��� $ Vertical=�$��Center=�$��0��.+��� $��Chemin du plugin (DLL) :���� $��Titre de l'action :���� $��Classe de la fonction :���� $��Nom de la fonction :���� $ ��Fenêtre de paramètrage :���� $ Vertical=�$��Center=�$��1��.+��� $ 
Horizontal=�.+��� -    ��Name$ 
TB_DllPath��	 �� 
IsReadOnly	 . $	��211���� -   
 ��Name$
 BT_ChooseDLL��$	��...��  SecondaryButtonStyle#���  $
��5, 0q��� $ 
Horizontal=�$
��0,10q�.+�'   !MyFunctions.ControlsWPF.MyTextBox  -     Name$ TB_ActionName��   DefaultText$ Titre en Français��$	��117��$	��5,0q�  -   $ TB_ActionName_English��$ Titre en Anglais��$	��117��$	��5,0q��� -   $ TB_MethodClass��$
��0, 9q��� -   $ TB_MethodName��$
��0, 7q��� -   $ TB_ParamsDialog��$
��0, 9q��� -   $
 BT_AddPlugin��$��Ajouter le plugin��$��20q�