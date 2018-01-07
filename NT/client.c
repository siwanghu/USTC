#include <stdio.h>  
#include <sys/types.h>  
#include <sys/socket.h>  
#include <netinet/in.h>  
#include <arpa/inet.h>  

#define SIZE 1024
      
int main(int argc, char *argv[])  
{
	int len;  
    char buf[SIZE];

    int client_socket;  
    struct sockaddr_in server_socket;

    memset(&server_socket,0,sizeof(server_socket)); 
    server_socket.sin_family=AF_INET;
    server_socket.sin_addr.s_addr=inet_addr("127.0.0.1");
    server_socket.sin_port=htons(9999);

    
    if((client_socket=socket(PF_INET,SOCK_STREAM,0))<0)  
    {  
        perror("socket");  
        return 1;  
    }  
          
    if(connect(client_socket,(struct sockaddr *)&server_socket,sizeof(struct sockaddr))<0)  
    {  
        perror("connect");  
        return 1;  
    }  

    printf("connected to server!\n");  
    len=recv(client_socket,buf,SIZE,0);
    buf[len]='/0';  
    printf("\n%s\n\n",buf);
          
    while(1)  
    {  
        printf("Enter message to send:");  
        scanf("%s",buf);  
        if(!strcmp(buf,"quit"))  
            break;  
        len=send(client_socket,buf,strlen(buf),0);  
        len=recv(client_socket,buf,SIZE,0);  
        printf("\nreceived:%s\n",buf);  
    }  
    close(client_socket);
    return 0;  
}  
 


