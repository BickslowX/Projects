   M S B A M L   `   `   `  ����A  =prac03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:prac03prac03  5   	       prac03.Administration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:prac03     5   	     � Title$  Administration��5   	   $	��585��6    $
��1042��6-   .��5	      � .+�5
   
   �� $@��:Введіть пароль адиміністратора��6   $
��Left=�69   $��	47,40,0,0q�6T   $	��Top=�6g   $��Arial Black)�6   $��16(�6�   �� 5   
   -   5         ��Name$ AdminPasswd��5      $
��Left=�6'   $��	47,85,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��150��6�   $��Baskerville Old Face)�6�   $��16(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ AutoriseBtn��5      $"��Авторизуватись��6&   $
��Left=�6?   $��
47,121,0,0q�6Z   $	��Top=�6n   $��40��6�   $	��367��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $>��8Перегляд користувачів списком��6   $
��Left=�68   $��
47,166,0,0q�6S   $	��Top=�6g   $��Baskerville Old Face)�6   $��14(�6�   $	��247��6�   $��Italic$�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $��47,203,628,28q�6P   $��Baskerville Old Face)�6g   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $:��4Зміна паролю адміністратора��6   $
��Left=�66   $��
453,40,0,0q�6Q   $	��Top=�6e   $��Arial Black)�6}   $��16(�6�   �� 5   
   $2��,Введіть поточний пароль��6   $
��Left=�62   $��
453,92,0,0q�6M   $	��Top=�6a   $	��197��6y   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $,��&Введіть новий пароль��6   $
��Left=�6/   $��
712,92,0,0q�6J   $	��Top=�6^   $	��208��6v   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5        $ RealAdminPasswd��5      $
��Left=�6+   $��453,125,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��197��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5        $ NewAdminPasswd��5      $
��Left=�6*   $��712,125,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��208��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $%��Повторіть пароль��6   $
��Left=�6+   $��453,170,0,0q�6F   $	��Top=�6[   $	��149��6s   $��Baskerville Old Face)�6   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5        $ NewAdminPasswd2��5      $
��Left=�6+   $��602,173,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��108��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5        $ UpdatePasswd��5      $��Оновити��6'   $
��Left=�69   $��721,169,0,0q�6T   $	��Top=�6i   $��18��6�   $	��199��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $<��6Перегляд кожного користувача��6   $
��Left=�67   $��453,215,0,0q�6R   $	��Top=�6g   $	��300��6   $��Arial Black)�6�   $��16(�6�   $��Normal$�6�   $��Normal"�6�   �� 5   
   $$��Ім'я користувача��6   $
��Left=�6+   $��453,246,0,0q�6F   $	��Top=�6[   $	��149��6s   $��Baskerville Old Face)�6   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $-��'Прізвище користувача��6   $
��Left=�6/   $��453,285,0,0q�6J   $	��Top=�6_   $	��170��6w   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5        $
 Prev��5      $��Попередній��6   $
��Left=�64   $��458,320,0,0q�6O   $	��Top=�6d   $��23��6|   $	��133��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $*��$Обмеження на пароль��6   $
��Left=�6.   $��620,321,0,0q�6I   $	��Top=�6^   $	��142��6v   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -	   5         ��Name$ UserRestrictionSelected��5      $�� ��61   $
��Left=�6<   $��762,322,0,0q�6W   $	��Top=�6l   $��42��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -
   5        $
 Next��5      $��Наступний��6   $
��Left=�63   $��809,320,0,0q�6N   $	��Top=�6c   $��23��6{   $	��172��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $/��)Додавання користувача��6   $
��Left=�60   $��453,364,0,0q�6K   $	��Top=�6`   $	��183��6x   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $��Користувач��6   $
��Left=�6%   $��672,364,0,0q�6@   $	��Top=�6U   $��99��6m   $��Baskerville Old Face)�6x   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5    
   -   5         ��Name$ UsersLogins��5       $
��Left=�6(   $��790,366,0,0q�6C   $	��Top=�6X   $	��191��6p   $��Baskerville Old Face)�6|   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5!   
   -   5         ��Name$ ChangeActive��5!      $��Активність��6)   $
��Left=�6>   $��668,405,0,0q�6Y   $	��Top=�6n    d� 	IsChecked$
 TrueY�6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5"   
   -   5        $ ChangeRestriction��5"      $*��$Обмеження на пароль��6.   $
��Left=�6L   $��668,437,0,0q�6g   $	��Top=�6|   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5#   
   -   5        $ CorrectRestrictionBtn��5#      $��Встановити��60   $
��Left=�6E   $��858,434,0,0q�6`   $	��Top=�6u   $��18��6�   $	��123��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6  �� 5$   
   -   5        $ CorrectStatusBtn��5$      $/��)Встановити активність��6+   $
��Left=�6K   $��790,405,0,0q�6f   $	��Top=�6{   $��18��6�   $	��191��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6  �� 5%   
   -   5        $ AddingUserLogin��5%      $
��Left=�6+   $��453,402,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5&   
   -   5        $ AddUser��5&      $)��#Додати користувача��6"   $
��Left=�6?   $��453,430,0,0q�6Z   $	��Top=�6o   $��18��6�   $	��138��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5'   
   -   5        $ ExitFromSystem��5'      $"��Вийти з системи��6)   $
��Left=�6C   $��453,465,0,0q�6^   $	��Top=�6s   $��18��6�   $	��138��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6  �� 5(   
   -   5        $ Close��5(      $��Закрити вікно��6    $
��Left=�68   $��671,494,0,0q�6S   $	��Top=�6h   $��47��6�   $	��310��6�   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5)   
   $��
Логін��6   $
��Left=�6    $��812,246,0,0q�6;   $	��Top=�6P   $��60��6h   $��Baskerville Old Face)�6s   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5*   
   $��Статус��6   $
��Left=�6!   $��812,285,0,0q�6<   $	��Top=�6Q   $��72��6i   $��Baskerville Old Face)�6t   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5+   
   -   5        $ UserNameSelected��5+      $�� ��6*   $
��Left=�65   $��648,243,0,0q�6P   $	��Top=�6e   $��Baskerville Old Face)�6}   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5,   
   -   5        $ UserSurnameSelected��5,      $�� ��6-   $
��Left=�68   $��648,285,0,0q�6S   $	��Top=�6h   $��Baskerville Old Face)�6�   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5-   
   -   5        $ UserLoginSelected��5-      $�� ��6+   $
��Left=�66   $��890,246,0,0q�6Q   $	��Top=�6f   $��Baskerville Old Face)�6~   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5.   
   -   5        $ UserStatusSelected��5.      $�� ��6,   $
��Left=�67   $��890,285,0,0q�6R   $	��Top=�6g   $��Baskerville Old Face)�6   $��14(�6�   $��Italic$�6�   $
��Bold"�6�   50      51      