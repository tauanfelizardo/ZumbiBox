﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool m_OnCross;
    public bool Move(Vector2 direction)
    { 
        if(BoxBlocked(transform.position, direction))
        { 
            return false;
        }
        else
        { 
            transform.Translate(direction);
            TestForOnCross();
            return true;
        }
    }

        void TestForOnCross()
    { 
        GameObject[] crosses = GameObject.FindGameObjectsWithTag("Cross");
        foreach(var cross in crosses)
        { 
            if(transform.position.x == cross.transform.position.x && transform.position.y == cross.transform.position.y)
            { 
                GetComponent<SpriteRenderer>().color = Color.green;
                m_OnCross = true;
                return;
            }
        }
        GetComponent<SpriteRenderer>().color = Color.red;
        m_OnCross = false;
    }

    bool BoxBlocked(Vector3 position, Vector2 direction)
    { 
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        GameObject[] wallsLD = GameObject.FindGameObjectsWithTag("LeftDown");
        GameObject[] wallsLS = GameObject.FindGameObjectsWithTag("LeftSide");
        GameObject[] wallsLU = GameObject.FindGameObjectsWithTag("LeftUp");
        GameObject[] wallsRD = GameObject.FindGameObjectsWithTag("RightDown");
        GameObject[] wallsRS = GameObject.FindGameObjectsWithTag("RightSide");
        GameObject[] wallsRU = GameObject.FindGameObjectsWithTag("RightUp");
        GameObject[] wallsUW = GameObject.FindGameObjectsWithTag("UpWall");
        GameObject[] wallsULW = GameObject.FindGameObjectsWithTag("UpLeWall");
        GameObject[] wallsURW = GameObject.FindGameObjectsWithTag("UpRiWall");
        foreach(var wallLD in wallsLD)
        { 
            if(wallLD.transform.position.x == newPos.x && wallLD.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        foreach(var wallLS in wallsLS)
        { 
            if(wallLS.transform.position.x == newPos.x && wallLS.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        foreach(var wallLU in wallsLU)
        { 
            if(wallLU.transform.position.x == newPos.x && wallLU.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        foreach(var wallRD in wallsRD)
        { 
            if(wallRD.transform.position.x == newPos.x && wallRD.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        foreach(var wallRS in wallsRS)
        { 
            if(wallRS.transform.position.x == newPos.x && wallRS.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
          foreach(var wallRU in wallsRU)
        { 
            if(wallRU.transform.position.x == newPos.x && wallRU.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        foreach(var wallUW in wallsUW)
        { 
            if(wallUW.transform.position.x == newPos.x && wallUW.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        foreach(var wallULW in wallsULW)
        { 
            if(wallULW.transform.position.x == newPos.x && wallULW.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        foreach(var wallURW in wallsURW)
        { 
            if(wallURW.transform.position.x == newPos.x && wallURW.transform.position.y == newPos.y)
            { 
                return true;
            }
        }

        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach(var box in boxes)
        { 
            if(box.transform.position.x == newPos.x && box.transform.position.y == newPos.y)
            { 
                return true;
            }
        }
        return false;
    }

}
