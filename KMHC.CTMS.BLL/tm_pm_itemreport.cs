/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2015-12-02                                         创建 
 *  
 */
 
using Project.Common.Helper;
using Project.DAL;
using Project.DAL.Database;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.BLL
{
    public class tm_pm_itemreportBLL
    {
        protected static tm_pm_itemreportDAL dal = new tm_pm_itemreportDAL();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_tm_pm_itemreport model)
        {
             if (model == null)
                return string.Empty;
            tm_pm_itemreport entity = ModelToEntity(model);
            entity.TASKID = string.IsNullOrEmpty(model.TASKID) ? Guid.NewGuid().ToString("N") : model.TASKID;

            return dal.Add(entity);
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_tm_pm_itemreport Get(Expression<Func<tm_pm_itemreport, bool>> predicate = null)
        {
            tm_pm_itemreport entity= dal.Get(predicate);
            return EntityToModel(entity); 
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_itemreport> Get()
        {
            List<tm_pm_itemreport> entitys = dal.Get().ToList();
            List<V_tm_pm_itemreport> list = new List<V_tm_pm_itemreport>();
            foreach (tm_pm_itemreport item in entitys)
            {
                list.Add(EntityToModel(item));
            }
            return list;
        }
        
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_itemreport> GetList(PageInfo page)
        {
            var list = dal.Get();

            return list.Paging(ref page).Select(EntityToModel).ToList();
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_tm_pm_itemreport model)
        {
            if (model == null) return false;
            tm_pm_itemreport entitys = ModelToEntity(model);
            
            return dal.Edit(entitys);
        }
        
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            return dal.Delete(id);
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private tm_pm_itemreport ModelToEntity(V_tm_pm_itemreport model)
        {
            if (model != null)
            {
                tm_pm_itemreport entity = new tm_pm_itemreport()
                {
                	                    	TASKID = model.TASKID,
                                        	PRETASK = model.PRETASK,
                                        	SUBMITDATE = model.SUBMITDATE,
                                        	SUBMITPROGRESS = model.SUBMITPROGRESS,
                                        	SUBMITREMARK = model.SUBMITREMARK,
                                        	PMANAGER = model.PMANAGER,
                                        	ISCOMFIRM = model.ISCOMFIRM,
                                        	STARTDATE = model.STARTDATE,
                                        	COMFIRMDATE = model.COMFIRMDATE,
                                        	OWENRID = model.OWENRID,
                                        	OWNERDEPARTMENTID = model.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = model.OWNERCOMPANYID,
                                        	CREATETIME = model.CREATETIME,
                                        	CREATEUSER = model.CREATEUSER,
                                        	EDITTIME = model.EDITTIME,
                                        	EDITUSER = model.EDITUSER,
                                    };

                return entity;
            }
            return null;
        }

        /// <summary>
        /// Entity转Model
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private V_tm_pm_itemreport  EntityToModel(tm_pm_itemreport  entity)
        {
            if (entity != null)
            {
                V_tm_pm_itemreport  model = new V_tm_pm_itemreport ()
                {
                                       	TASKID = entity.TASKID,
                                        	PRETASK = entity.PRETASK,
                                        	SUBMITDATE = entity.SUBMITDATE,
                                        	SUBMITPROGRESS = entity.SUBMITPROGRESS,
                                        	SUBMITREMARK = entity.SUBMITREMARK,
                                        	PMANAGER = entity.PMANAGER,
                                        	ISCOMFIRM = entity.ISCOMFIRM,
                                        	STARTDATE = entity.STARTDATE,
                                        	COMFIRMDATE = entity.COMFIRMDATE,
                                        	OWENRID = entity.OWENRID,
                                        	OWNERDEPARTMENTID = entity.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = entity.OWNERCOMPANYID,
                                        	CREATETIME = entity.CREATETIME,
                                        	CREATEUSER = entity.CREATEUSER,
                                        	EDITTIME = entity.EDITTIME,
                                        	EDITUSER = entity.EDITUSER,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
