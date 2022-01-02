using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.IDAL
{
    public interface INoticeDal
    {
        // 1. 공지사항 리스트 출력
        List<Notice> GetNoticeList();
        // 2. 공지사항 상세 출력
        Notice GetNotice(int noticeNo);
        // 3. 공지사항 등록
        bool PostNotice(Notice notice);
        // 4. 공지사항 수정
        bool UpdateNotice(Notice notice);
        // 5. 공지사항 삭제
        bool DeleteNotice(int noticeNo);
    }
}
