   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Library.GUILibrary.GUI  5   	       Library.GUI.BooksWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Library.GUI     5   	     � Title$  BooksWindow��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5   
   � -   5         �Name$
 Grid��5      $��
0,33,20,33q�6   $y�Visible=�61   .+�5      �� -   5         ��Name$ TextBoxTitre��5      $��Center=�6,   $��0,50,0,0q�6I    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5      -   5        $ TextBoxAuteur��5      $��Center=�6-   $��	0,104,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5      -   5        $ TextBoxCategorie��5      $��Center=�60   $��	0,149,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5      $��
Disponible��6   $
��Left=�6)   $��239,198,0,0q�6D   $	��Top=�6Y   $��65��6q   �� 5      -   5        $��Ajouter un livre��5      $
��Left=�60   $��617,326,0,0q�6K   $	��Top=�6`   $	��114��6�   �� 5      -   5         ��Name$ 	BrowseBtn��5      $��Browse��6(   $
��Left=�69   $	��Top=�6T   $��75��6l   $��493,266,0,0q�6w   6�   �� 5      $��Titre��6   $
��Left=�6$   $��
239,50,0,0q�6?   $	��Top=�6S   $��65��6k   �� 5      $��Auteur��6   $
��Left=�6%   $��
239,95,0,0q�6@   $	��Top=�6T   $��65��6l   �� 5      $��	Categorie��6   $
��Left=�6(   $��239,149,0,0q�6C   $	��Top=�6X   $��65��6p   �� 5      -   5        $ TextBoxBrowse��5       �� 
IsReadOnly$
 True��6-   $
��Left=�6?   $	��Top=�6Z   $	��138��6r   $��330,266,0,0q�6~   $��19��6�   �� 5      $��Image��6   $
��Left=�6$   $��239,253,0,0q�6?   $	��Top=�6T   $��65��6l   �� 5       -   5        $ TextBoxDisponible��5       $��Center=�61   $��	0,206,0,0q�6N   $
 Wrap=�6a   $	��Top=�6v   $	��120��6�   &   System.Windows.Controls.DataGrid  5!      -	   5          Name$ dataGridBooks��5!         AutoGenerateColumns$
 True��6.   $y�Hidden=�6I   �� 5"      $��Description��6   $
��Left=�6*   $��239,323,0,0q�6E   $	��Top=�6Z   $��89��6r   �� 5#      -
   5        $ TextBoxDescription��5#      $
��Left=�62   $��348,327,0,0q�6M   $
 Wrap=�6b   $	��Top=�6w   $	��120��6�   5%      5'      5(      