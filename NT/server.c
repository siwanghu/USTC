#include <stdio.h>  
#include <sys/types.h>  
#include <sys/socket.h>  
#include <netinet/in.h>  
#include <arpa/inet.h>  

#define SIZE 1024
      
int main(int argc, char *argv[])  
{
	int size,len;
    char buf[SIZE];
    int server_socket; 
    int client_socket;  

    struct sockaddr_in server_address;    
    struct sockaddr_in client_address;  

    memset(&server_address,0,sizeof(server_address));
    server_address.sin_family=AF_INET;
    server_address.sin_addr.s_addr=INADDR_ANY;
    server_address.sin_port=htons(9999);
          

    if((server_socket=socket(PF_INET,SOCK_STREAM,0))<0)  
    {     
        return 1;  
    }  
      
    if (bind(server_socket,(struct sockaddr *)&server_address,sizeof(struct sockaddr))<0)  
    {  
        return 1;  
    }  
          
 
    listen(server_socket,5);         
	
	size=sizeof(struct sockaddr_in);          
    if((client_socket=accept(server_socket,(struct sockaddr *)&client_address,&size))<0)  
    {   
        return 1;  
    }  

    send(client_socket,"Welcome to my server!",22,0);

    while((len=recv(client_socket,buf,SIZE,0))>0)  
    {  
        printf("\n%s\n",buf);  
        if(send(client_socket,buf,len,0)<0)  
        {  
            return 1;  
        }  
    }  
    close(client_socket);  
    close(server_socket);  
    return 0;  
}  

