class CreateLecturas < ActiveRecord::Migration
  def change
    create_table :lecturas do |t|
      t.timestamp :fecha

      t.timestamps
    end
  end
end
