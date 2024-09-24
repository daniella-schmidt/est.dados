/* é um tipo de estrutura de dados onde o último nó aponta de
 volta para o primeiro nó, formando um ciclo. Isso significa que, 
 ao percorrer a lista a partir de qualquer ponto, eventualmente você retornará ao ponto inicial.

Características Principais:
- Ciclo Fechado: O último nó da lista aponta para o primeiro nó.
- Navegação Contínua: Você pode percorrer a lista indefinidamente sem encontrar um ponto final.
- Uso de Ponteiros: Cada nó contém um valor e um ponteiro para o próximo nó.*/

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

public class CircularLinkedList
{
    private Node head;
    private Node tail;

    public CircularLinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddToEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            head.Next = tail; // Liga o primeiro nó ao último nó (circular)
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head; // Liga o novo nó ao primeiro nó (circular)
        }
    }

    public void AddToBeginning(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            head.Next = tail; // Liga o primeiro nó ao último nó (circular)
        }
        else
        {
            newNode.Next = head;
            head = newNode;
            tail.Next = head; // Liga o novo nó ao primeiro nó (circular)
        }
    }

    public void Remove(int data)
    {
        if (head == null) return;

        Node current = head;
        Node previous = null;

        do
        {
            if (current.Data == data)
            {
                if (previous == null)
                {
                    head = current.Next;
                    tail.Next = head; // Liga o último nó ao novo primeiro nó (circular)
                }
                else
                {
                    previous.Next = current.Next;
                    if (current.Next == head)
                    {
                        tail = previous; // Atualiza o último nó
                    }
                }
                return;
            }
            previous = current;
            current = current.Next;
        } while (current != head);
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        Node current = head;
        do
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        } while (current != head); // Sai do loop quando volta ao primeiro nó
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList list = new CircularLinkedList();
        list.AddToEnd(1);
        list.AddToEnd(2);
        list.AddToEnd(3);
        list.AddToEnd(4);

        list.Display(); // Saída: 1 2 3 4

        list.AddToBeginning(0);
        list.Display(); // Saída: 0 1 2 3 4

        list.Remove(2);
        list.Display(); // Saída: 0 1 3 4
    }
}
