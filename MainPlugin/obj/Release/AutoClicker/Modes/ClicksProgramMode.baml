   M S B A M L   `   `   `  ���� E  AMainPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MainPlugin.AutoClicker.ModesMainPlugin.AutoClicker.Modes  F BMyFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctionsMyFunctions.ControlsWPF 4    .MainPlugin.AutoClicker.Modes.ClicksProgramMode   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:MainPlugin.AutoClicker.Modes     Jmyf:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctions     .����   �� Orientation$  Vertical=�.+��� -    ��Name$ BT_OpenProgram��$#��Ouvrir un programme de clicks��$��16(����#DDDDDD
���   ��� 
���   �$��1q�$��0,10,0,0q�._��� $  Vertical=�.+��� $  
Horizontal=�$	��0,1q�$��Center=�.+��� -   $ BT_AddPoints��$��Ajouter un point de click��$��14(����#DDDDDD
���   ��� -   $ BT_RemovePoint��$��	Supprimer��$��14(����#DDDDDD$��5,0,0,0q�
���   ��� -   $ BT_VisualisePoint��$��
Visualiser��$��14(����#DDDDDD$��5,0,0,0q�
���   ��� -    ��Name$ 	LV_Points��$��14(�$��Visible=�$	��223���� $  
Horizontal=�$��Center=�.+��� $$��Intervalle (en milliseconde) :��$��14(�
���   �+  %MyFunctions.ControlsWPF.NumericUpDown  -     Name$ NUD_Interval��
   Min$ 1Q�
   Max$ 1E+30Q�   Value$
 1000Q��� $  
Horizontal=�$��Center=�$��0,5,0,0q�.+��� $��Nombre de répétitions :��$��14(�
���   �  -   $ 
NUD_Repeat��$ 1Q�$ 10Q�$ 1Q��� -   $ BT_SaveProgram��$(��"Enregistrer un programme de clicks��$��16(����#DDDDDD$��0,10,0,2q�
���   �