/***********************************************************
* 版本: V1.0
* 创建人：胡思旺
* 创建时间：2017年9月20日 
* 版权所有:胡思旺
* 说明：未经作者同意不得用于商业用途
* 联系方式:siwanghu@hotmail.com
************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI
{
    public interface CallBack
    {
        void callback(List<string> buffer);
    }
}
