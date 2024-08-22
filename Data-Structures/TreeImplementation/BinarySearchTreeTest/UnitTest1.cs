//using System;
//using System.IO;
//using System.Xml.Linq;
//using TreeImplementation;
//using Xunit;

//public class BinaryTreeTests
//{
//    // Helper method to capture Console output
//    private string CaptureConsoleOutput(Action action)
//    {
//        using (var sw = new StringWriter())
//        {
//            Console.SetOut(sw);
//            action();
//            return sw.ToString().Trim();
//        }
//    }

//    [Fact]
//    public void PreOrder()
//    {
//        // Arrange
//        var tree = new BinarySearchTree(4)
//        {
//            Root = new TNode(4)
//            {
//                left = new TNode(2)
//                {
//                    left = new TNode(1),
//                    right = new TNode(3)
//                },
//                right = new TNode(6)
//                {
//                    left = new TNode(5),
//                    right = new TNode(7)
//                }
//            }
//        };

//        // Act
//        string output = CaptureConsoleOutput(() => tree.Pre_Order(tree.Root));

//        // Assert
//        Assert.Equal("4->2->1->3->6->5->7->", output);
//    }

//    [Fact]
//    public void InOrder()
//    {
//        // Arrange
//        var tree = new BinarySearchTree(4)
//        {
//            Root = new TNode(4)
//            {
//                left = new TNode(2)
//                {
//                    left = new TNode(1),
//                    right = new TNode(3)
//                },
//                right = new TNode(6)
//                {
//                    left = new TNode(5),
//                    right = new TNode(7)
//                }
//            }
//        };

//        // Act
//        string output = CaptureConsoleOutput(() => tree.In_Order(tree.Root));

//        // Assert
//        Assert.Equal("1->2->3->4->5->6->7->", output);
//    }

//    [Fact]
//    public void PostOrder()
//    {
//        // Arrange
//        var tree = new BinarySearchTree(4)
//        {
//            Root = new TNode(4)
//            {
//                left = new TNode(2)
//                {
//                    left = new TNode(1),
//                    right = new TNode(3)
//                },
//                right = new TNode(6)
//                {
//                    left = new TNode(5),
//                    right = new TNode(7)
//                }
//            }
//        };

//        // Act
//        string output = CaptureConsoleOutput(() => tree.Post_Order(tree.Root));

//        // Assert
//        Assert.Equal("1->3->2->5->7->6->4->", output);
//    }
//}