export interface FAQModel {
    id: number | null;
    question: string;
    answer: string;
    active: boolean;
    created_at: string | null;
    updated_at: string | null;
  }
  export interface FAQCreateModel {
    question: string;
    answer: string;
    active: boolean;
  }
  