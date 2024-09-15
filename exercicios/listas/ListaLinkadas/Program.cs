/*estrutura de dados linear composta por uma sequência de elementos 
chamados nós. Cada nó contém dois componentes principais:

+ Dados: O valor armazenado no nó.
+ Ponteiro: Um link para o próximo nó na sequência.

Tipos de Listas Ligadas
- Lista Simplesmente Ligada (Singly Linked List): Cada nó aponta para o próximo nó.
A navegação é unidirecional (do início ao fim).
- Lista Duplamente Ligada (Doubly Linked List): Cada nó possui dois ponteiros: 
um para o próximo nó e outro para o nó anterior.
A navegação pode ser feita em ambas as direções (do início ao fim e vice-versa).*/

using System;

public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void AddToEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.AddToEnd(1);
        list.AddToEnd(2);
        list.AddToEnd(3);
        list.AddToEnd(4);

        list.Display();
    }
}
