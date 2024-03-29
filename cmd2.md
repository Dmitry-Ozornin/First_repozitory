## Подсказки по Git
Команда смены директории
```sh
cd ~/folder_name
```
Команда отображения текущей директории.
```sh
pwd
```
Листинг текущей директории windows:
```sh
dir
```
Удаление файлов windows:
```sh
del 
```
Создали репозиторий
```sh
git init
```
Команда добавления отслеживания файла
```sh
git add имя файла.формат
```
Показ статуса файла
```sh
git status
```
Добавление комменария по внесенным изменениям:
```sh
git commit -m "текс"
```
Логи внеменных изменений
```sh
git log
git log --oneline мини версия
```
Переход по версиям внесенных изменений
```sh
git checkout идетификатор
```
Переход к актуальной версии файла
```sh
git checkout master
```
Отмена измененений до предыдущего уровня фиксации
```sh
git restore имя файла.формат
```
Просмотр отличий от предыдущей версии
```sh
git diff
```
Команда просмотра веток и на какой ветке находишься
```sh
git branch
```
Команда создания новой ветки
```sh
git branch имя ветки
```
Команда объеденения ветки с текущей веткой
```sh
git merge имя ветки
```
Удаление ветки
```sh
git branch -d файловое имя
```
Просмотр истории работы с веткам
```sh
git log --graph
git log --oneline --graph
```
### Работа с удаленным репозиторием

Скачивание репорзитория с github.com
```sh
git clone адресная ссылка с github
```
Привязка удаленного реозитория
```sh
git remote add origin git remote add origin https://github.com/Dmitry-Ozornin/
git branch -M main
git push -u origin main
```
Запрос изменений с удаленного сервера
```sh
git pull
```
Заливка на сервер
```sh
git push
```
Добавление ветки на удаленные репозиторий
```sh
git push --set-upstream origin название ветки
```