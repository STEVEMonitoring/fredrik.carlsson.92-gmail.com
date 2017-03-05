using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEVE.Source_files_cpp
{
    class LCDdisplaySmall
    {
        public void lcdInit()
        {
            byte CMD_COM_END_H = 0xF1;               
            byte CMD_COM_END_L = 0x67;                
            byte CMD_MAPPING_CTRL = 0xC0;      
            byte CMD_SCROLL_LINE_H = 0x40;               	
            byte CMD_SCROLL_LINE_L = 0x50;         
            byte CMD_PANEL_LOADING_38NF = 0x2B;            
            byte CMD_BIAS_RATIO_12 = 0xEB;                
            byte CMD_CONTRAST = 0x81;           
            byte LCD_CONTRAST_VALUE = 0x5F;	 
            byte CMD_RAM_ADDR_AUTO = 0x89;	    
            byte CMD_DISPLAY_ON = 0xAF;     
            
            
        }

        public void writeLcd(string message)
        {

        }
    }
}
