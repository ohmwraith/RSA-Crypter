# RSA Crypter
Это приложение Windows Forms для шифрования и расшифровки текста с использованием RSA, а также симметричных алгоритмов шифрования.

![image](https://user-images.githubusercontent.com/44874495/236053769-6154395e-175a-4b76-90be-18fefb77c9d7.png)

## Использование
Для использования приложения следуйте этим шагам:

1. Запустите приложение.
2. Сгенерируйте новую пару RSA ключей, нажав "Ключи RSA" -> "Новая пара". Это создаст новую пару ключей RSA 512-бит.
3. Сохраните ключи, нажав "Ключи RSA" -> "Сохранить ключи" -> "Сохранить пару". Это сохранит приватный ключ в формате .pem.
4. Сохраните публичный ключ, нажав "Ключи RSA" -> "Сохранить ключи" -> "Сохранить открытый". Это сохранит публичный ключ в формате .pub.
5. Чтобы зашифровать сообщение, введите сообщение в поле "Decrypted" и нажмите "Зашифровать". Зашифрованное сообщение появится в поле "Crypted".
6. Чтобы расшифровать сообщение, загрузите зашифрованное сообщение в поле "Crypted" c помощью кнопки открыть файл и нажмите "Расшифровать". Расшифрованное сообщение появится в поле "Decrypted".
## Операции с файлами
Приложение также позволяет выполнять различные операции с файлами. Вы можете использовать следующие пункты меню и кнопки:

- "Файл" -> "Открыть открытый ключ" - загрузить публичный ключ из файла.
- "Файл" -> "Зашифровать в файл" - зашифровать данные и сохранить их в файл.
- "Файл" -> "Расшифровать файл" - расшифровать данные из файла.
- "Открыть" - открыть файл и загрузить его содержимое в поле "Расшифрованный".
- "Сохранить" - сохранить содержимое поля "Расшифрованный" в файл.
- "Открыть шифртекст" - открыть файл и загрузить его содержимое в поле "Зашифрованный".
- "Сохранить шифртекст" - сохранить содержимое поля "Зашифрованный" в файл.
