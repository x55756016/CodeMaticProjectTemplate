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
    public class tm_pm_postBLL
    {
        protected static tm_pm_postDAL dal = new tm_pm_postDAL();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_tm_pm_post model)
        {
             if (model == null)
                return string.Empty;
            tm_pm_post entity = ModelToEntity(model);
            entity.POSTID = string.IsNullOrEmpty(model.POSTID) ? Guid.NewGuid().ToString("N") : model.POSTID;

            return dal.Add(entity);
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_tm_pm_post Get(Expression<Func<tm_pm_post, bool>> predicate = null)
        {
            tm_pm_post entity= dal.Get(predicate);
            return EntityToModel(entity); 
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_post> Get()
        {
            List<tm_pm_post> entitys = dal.Get().ToList();
            List<V_tm_pm_post> list = new List<V_tm_pm_post>();
            foreach (tm_pm_post item in entitys)
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
        public IEnumerable<V_tm_pm_post> GetList(PageInfo page)
        {
            var list = dal.Get();

            return list.Paging(ref page).Select(EntityToModel).ToList();
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_tm_pm_post model)
        {
            if (model == null) return false;
            tm_pm_post entitys = ModelToEntity(model);
            
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
        private tm_pm_post ModelToEntity(V_tm_pm_post model)
        {
            if (model != null)
            {
                tm_pm_post entity = new tm_pm_post()
                {
                	                    	POSTID = model.POSTID,
                                        	POSTDICTIONARYID = model.POSTDICTIONARYID,
                                        	COMPANYID = model.COMPANYID,
                                        	DEPARTMENTID = model.DEPARTMENTID,
                                        	DEPARTMENTNAME = model.DEPARTMENTNAME,
                                        	POSTNAME = model.POSTNAME,
                                        	POSTFUNCTION = model.POSTFUNCTION,
                                        	POSTNUMBER = model.POSTNUMBER,
                                        	POSTLEVEL = model.POSTLEVEL,
                                        	POSTCOEFFICIENT = model.POSTCOEFFICIENT,
                                        	SALARYLEVEL = model.SALARYLEVEL,
                                        	POSTGOAL = model.POSTGOAL,
                                        	FATHERPOSTID = model.FATHERPOSTID,
                                        	UNDERNUMBER = model.UNDERNUMBER,
                                        	PROMOTEDIRECTION = model.PROMOTEDIRECTION,
                                        	CHANGEPOST = model.CHANGEPOST,
                                        	CHECKSTATE = model.CHECKSTATE,
                                        	EDITSTATE = model.EDITSTATE,
                                        	CREATEUSERID = model.CREATEUSERID,
                                        	CREATEDATE = model.CREATEDATE,
                                        	UPDATEUSERID = model.UPDATEUSERID,
                                        	UPDATEDATE = model.UPDATEDATE,
                                        	CREATEPOSTID = model.CREATEPOSTID,
                                        	CREATEDEPARTMENTID = model.CREATEDEPARTMENTID,
                                        	CREATECOMPANYID = model.CREATECOMPANYID,
                                        	OWNERID = model.OWNERID,
                                        	OWNERPOSTID = model.OWNERPOSTID,
                                        	OWNERDEPARTMENTID = model.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = model.OWNERCOMPANYID,
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
        private V_tm_pm_post  EntityToModel(tm_pm_post  entity)
        {
            if (entity != null)
            {
                V_tm_pm_post  model = new V_tm_pm_post ()
                {
                                       	POSTID = entity.POSTID,
                                        	POSTDICTIONARYID = entity.POSTDICTIONARYID,
                                        	COMPANYID = entity.COMPANYID,
                                        	DEPARTMENTID = entity.DEPARTMENTID,
                                        	DEPARTMENTNAME = entity.DEPARTMENTNAME,
                                        	POSTNAME = entity.POSTNAME,
                                        	POSTFUNCTION = entity.POSTFUNCTION,
                                        	POSTNUMBER = entity.POSTNUMBER,
                                        	POSTLEVEL = entity.POSTLEVEL,
                                        	POSTCOEFFICIENT = entity.POSTCOEFFICIENT,
                                        	SALARYLEVEL = entity.SALARYLEVEL,
                                        	POSTGOAL = entity.POSTGOAL,
                                        	FATHERPOSTID = entity.FATHERPOSTID,
                                        	UNDERNUMBER = entity.UNDERNUMBER,
                                        	PROMOTEDIRECTION = entity.PROMOTEDIRECTION,
                                        	CHANGEPOST = entity.CHANGEPOST,
                                        	CHECKSTATE = entity.CHECKSTATE,
                                        	EDITSTATE = entity.EDITSTATE,
                                        	CREATEUSERID = entity.CREATEUSERID,
                                        	CREATEDATE = entity.CREATEDATE,
                                        	UPDATEUSERID = entity.UPDATEUSERID,
                                        	UPDATEDATE = entity.UPDATEDATE,
                                        	CREATEPOSTID = entity.CREATEPOSTID,
                                        	CREATEDEPARTMENTID = entity.CREATEDEPARTMENTID,
                                        	CREATECOMPANYID = entity.CREATECOMPANYID,
                                        	OWNERID = entity.OWNERID,
                                        	OWNERPOSTID = entity.OWNERPOSTID,
                                        	OWNERDEPARTMENTID = entity.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = entity.OWNERCOMPANYID,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
