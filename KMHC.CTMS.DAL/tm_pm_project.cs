﻿/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2015-12-02                                         创建 
 *  
 */
 
using Project.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.DAL
{
    public class tm_pm_projectDAL : BaseDAL<tm_pm_project>
    {
    	/// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string Add(tm_pm_project entity)
        {
            base.Insert(entity);
            return entity.PROJECTID;
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Edit(tm_pm_project entity)
        {
            return base.Update(entity);
        }
		
		/// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return base.DeleteById(id);
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<tm_pm_project> Get()
        {
            return base.FindAll();
        }
        
        /// <summary>
        /// 单条数据
        /// </summary>
        /// <returns></returns>
        public tm_pm_project Get(Expression<Func<tm_pm_project, bool>> predicate = null)
        {
            return base.FindOne(predicate);
        }
    }
}