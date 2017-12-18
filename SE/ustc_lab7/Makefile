menu:main.o node.o LinkTable.o menu.o
	gcc -o menu main.o menu.o node.o LinkTable.o
main.o:main.c
	gcc -c main.c
node.o:node.c node.h
	gcc -c node.c
LinkTable.o:LinkTable.c LinkTable.h
	gcc -c LinkTable.c
menu.o:menu.c menu.h
	gcc -c menu.c
clean:
	rm -f *.o menu
